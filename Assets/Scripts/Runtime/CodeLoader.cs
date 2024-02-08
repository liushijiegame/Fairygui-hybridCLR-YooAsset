// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// using System.Reflection;
// using Cysharp.Threading.Tasks;
// using HybridCLR;
// using UnityEngine;
// using YooAsset;
//
// namespace MK
// {
//     public class CodeLoader : Singleton<CodeLoader>
//     {
//          // private Assembly model;
//         private static Dictionary<string, byte[]> s_assetDatas = new Dictionary<string, byte[]>();
//
//         public static byte[] ReadBytesFromStreamingAssets(string dllName)
//         {
//             return s_assetDatas[dllName];
//         }
//         private static Assembly _hotUpdateAss;
//         public async UniTask Start()
//         {
//             //补充元数据
//             await LoadMetadataForAOTAssemblies();
//         
// #if !UNITY_EDITOR
//         _hotUpdateAss = Assembly.Load(ReadBytesFromStreamingAssets("HotUpdate.dll.bytes"));
// #else
//             _hotUpdateAss = System.AppDomain.CurrentDomain.GetAssemblies().First(a => a.GetName().Name == "HotUpdate");
// #endif
//             IStaticMethod start1 = new StaticMethod(_hotUpdateAss, "Entry", "Start");
//             start1.Run();
//
//             // var assetHotfixProtoDllPath = AssetUtility.GetCodePath("HotUpdate.dll");
//             // var assetHotfixProtoDllOperationHandle = await AssetManager.Instance()
//             //     .LoadAssetAsync<UnityEngine.Object>(assetHotfixProtoDllPath);
//             // var assemblyDataHotfixProtoDll =
//             //     assetHotfixProtoDllOperationHandle.GetAssetObject<UnityEngine.TextAsset>().bytes;
//             // var assetHotfixProtoPdbPath = AssetUtility.GetCodePath("HotUpdate.pdb", "");
//             // var assetHotfixProtoPdbOperationHandle = await AssetManager.Instance()
//             //     .LoadAssetAsync<UnityEngine.Object>(assetHotfixProtoPdbPath);
//             // var assemblyDataHotfixProtoPdb =
//             //     assetHotfixProtoPdbOperationHandle.GetAssetObject<UnityEngine.TextAsset>().bytes;
//             //
//             // this.model = Assembly.Load(assemblyDataHotfixProtoDll, assemblyDataHotfixProtoPdb);
//             //
//             // IStaticMethod start = new StaticMethod(this.model, "Entry", "Start");
//             // start.Run();
//         }
//
//         private async UniTask  LoadMetadataForAOTAssemblies()
//         {
//             List<string> AOTMetaAssemblyFiles = new List<string>
//             {
//                 "GameCore.dll",
//                 "UniFramework.Event.dll",
//                 "UnityEngine.CoreModule.dll",
//                 "YooAsset.dll",
//                 "mscorlib.dll",
//             };
//             /// 注意，补充元数据是给AOT dll补充元数据，而不是给热更新dll补充元数据。
//             /// 热更新dll不缺元数据，不需要补充，如果调用LoadMetadataForAOTAssembly会返回错误
//             /// 
//             HomologousImageMode mode = HomologousImageMode.SuperSet;
//             foreach (var aotDllName in AOTMetaAssemblyFiles)
//             {
//                 RawFileHandle handle = YooAssets.LoadRawFileAsync($"Assets/GameRes/Code/{aotDllName}.bytes");
//                 await handle;
//                 byte[] dllBytes = handle.GetRawFileData();
//                 s_assetDatas[aotDllName] = dllBytes;
//                 // byte[] dllBytes = ReadBytesFromStreamingAssets(aotDllName);
//                 // 加载assembly对应的dll，会自动为它hook。一旦aot泛型函数的native函数不存在，用解释器版本代码
//                 LoadImageErrorCode err = RuntimeApi.LoadMetadataForAOTAssembly(dllBytes, mode);
//                 Debug.Log($"LoadMetadataForAOTAssembly:{aotDllName}. mode:{mode} ret:{err}");
//             }
//         }
//     }
// }