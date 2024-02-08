using Core;
using Core.Component;
using Core.UI;
using Cysharp.Threading.Tasks;
using MK.Core.Log;
using UnityEngine;
using YooAsset;

public class BattleTest: Singleton<BattleTest>
{
    public void Init()
    {
        CameraManager.Instance.Init();
    }

    private async UniTask<GameObject> CreateUnit(string unitName)
    {
        AssetHandle assetHandle =  YooAssets.LoadAssetAsync<GameObject>(unitName);
        await assetHandle;
        GameObject prefab = assetHandle.GetAssetObject<GameObject>();
        GameObject go = Object.Instantiate(prefab, GlobalUILayer.Instance.Unit, true);
        return go;
    }

    public void CreateCube()
    {
        UniTask.Void(async () =>
        {
            GameObject gameObject = await this.CreateUnit("Cube");
            gameObject.transform.position = new Vector3(0, 10, 10);
        });
    }
}
