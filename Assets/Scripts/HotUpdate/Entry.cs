using Core.FUI;
using Core.UI;
using HotUpdate.GameLogic;
using MK;
using Mk.Resource;

public class Entry
{
    public static void Start()
    {
        //测试
        FUICollectionService.Instance.Init();
        UIManager.Instance.Init();
        ResManager.Instance.Init();
        GlobalUILayer.Instance.Init();
        FUIAssetManager.Instance.Init();
        MKSceneManager.Instance.Init();
        UITest.Instance.Init();
    }
}