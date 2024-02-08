using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Core.FUI;
using Core.UI;
using Core.UI.Tool;
using HybridCLR;
using MK;
using Mk.Resource;
using UniFramework.Event;
using UnityEngine;
using UnityEngine.EventSystems;
using YooAsset;

public class Boot : MonoBehaviour
{
    /// <summary>
    /// 资源系统运行模式
    /// </summary>
    public EPlayMode PlayMode = EPlayMode.EditorSimulateMode;

    private static Dictionary<string, byte[]> s_assetDatas = new Dictionary<string, byte[]>();

    public static byte[] ReadBytesFromStreamingAssets(string dllName)
    {
        return s_assetDatas[dllName];
    }

    private static Assembly _hotUpdateAss;

    void Awake()
    {
        Debug.Log($"资源系统运行模式：{PlayMode}");
        Application.targetFrameRate = 60;
        Application.runInBackground = true;
        DontDestroyOnLoad(this.gameObject);
    }

    IEnumerator Start()
    {
        // 游戏管理器
        LoaderManager.Instance.Behaviour = this;

        // 初始化事件系统
        UniEvent.Initalize();

        // 初始化资源系统
        YooAssets.Initialize();
        // 加载更新页面
        var go = Resources.Load<GameObject>("PatchWindow");
        GameObject.Instantiate(go);

        // 开始补丁更新流程
        PatchOperation operation = new PatchOperation("DefaultPackage",
            EDefaultBuildPipeline.BuiltinBuildPipeline.ToString(), PlayMode);
        YooAssets.StartOperation(operation);
        yield return operation;
        // 更新热更代码
        PatchOperation operation_hotFix = new PatchOperation("CodeResPackage",
            EDefaultBuildPipeline.RawFileBuildPipeline.ToString(), PlayMode);
        YooAssets.StartOperation(operation_hotFix);
        yield return operation_hotFix;
        // 设置默认的资源包
        var gamePackage = YooAssets.GetPackage("DefaultPackage");
        YooAssets.SetDefaultPackage(gamePackage);
        // 补充元数据
        yield return LoadMetadataForAOTAssemblies();
        // 进入游戏
        IStaticMethod start = new StaticMethod(_hotUpdateAss, "Entry", "Start");
        start.Run();
    }


    /// <summary>
    /// 为aot assembly加载原始metadata， 这个代码放aot或者热更新都行。
    /// 一旦加载后，如果AOT泛型函数对应native实现不存在，则自动替换为解释模式执行
    /// </summary>
    private IEnumerator LoadMetadataForAOTAssemblies()
    {
        List<string> AOTMetaAssemblyFiles = new List<string>()
        {
            "GameCore.dll",
            "UniFramework.Event.dll",
            "UnityEngine.CoreModule.dll",
            "YooAsset.dll",
            "mscorlib.dll",
            // "GameCore.dll",
            // "System.Core.dll",
            // "UniTask.dll",
            // "UnityEngine.CoreModule.dll",
            // "YooAsset.dll",
            // "mscorlib.dll",
            "HotUpdate.dll"
        };
        /// 注意，补充元数据是给AOT dll补充元数据，而不是给热更新dll补充元数据。
        /// 热更新dll不缺元数据，不需要补充，如果调用LoadMetadataForAOTAssembly会返回错误
        /// 
        HomologousImageMode mode = HomologousImageMode.SuperSet;
        var hotfixPackage = YooAssets.GetPackage("CodeResPackage");
        foreach (var aotDllName in AOTMetaAssemblyFiles)
        {
            var handle = hotfixPackage.LoadRawFileAsync($"Assets/GameRes/Code/{aotDllName}.bytes");
            yield return handle;
            var bytes = handle.GetRawFileData();
            s_assetDatas[aotDllName] = bytes;
            byte[] dllBytes = ReadBytesFromStreamingAssets(aotDllName);
            // 加载assembly对应的dll，会自动为它hook。一旦aot泛型函数的native函数不存在，用解释器版本代码
            LoadImageErrorCode err = RuntimeApi.LoadMetadataForAOTAssembly(dllBytes, mode);
            Debug.Log($"LoadMetadataForAOTAssembly:{aotDllName}. mode:{mode} ret:{err}");
        }

#if !UNITY_EDITOR
         _hotUpdateAss = Assembly.Load(ReadBytesFromStreamingAssets("HotUpdate.dll"));
#else
        // Editor下无需加载，直接查找获得HotUpdate程序集
        _hotUpdateAss = System.AppDomain.CurrentDomain.GetAssemblies().First(a => a.GetName().Name == "HotUpdate");
#endif
        Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
        Dictionary<string, Type> types = AssemblyHelper.GetAssemblyTypes(assemblies);
        AttributeService.Instance.Add(types);
    }
}