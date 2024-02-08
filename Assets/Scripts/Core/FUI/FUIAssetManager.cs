using System.Collections.Generic;
using Core.UI.Tool;
using Cysharp.Threading.Tasks;
using FairyGUI;
using FairyGUI.Dynamic;
using MK;
using Mk.Resource;
using UnityEngine;

namespace Core.FUI
{
    public class FUIAssetManager : Singleton<FUIAssetManager>, IUIAssetManagerConfiguration
    {
        public UIAssetManager UIAssetManager;

        public Dictionary<int, string> Locations;

        public IUIPackageHelper PackageHelper { get; set; }

        public IUIAssetLoader AssetLoader { get; set; }

        public bool UnloadUnusedUIPackageImmediately { get; set; } = false;

        public void Init()
        {
            void LoadUIPackageAsyncHandler(string packageName, LoadUIPackageBytesCallback callback)
            {
                UniTask.Void(async () => { await LoadUIPackageAsyncInner(packageName, callback); });
            }

            void LoadTextureAsyncHandler(string packageName, string assetName, string extension,
                LoadTextureCallback callback)
            {
                UniTask.Void(async () => { await LoadTextureAsyncInner(assetName, callback); });
            }

            void LoadAudioClipAsyncHandler(string packageName, string assetName, string extension,
                LoadAudioClipCallback callback)
            {
                UniTask.Void(async () => { await LoadAudioClipAsyncInner(assetName, callback); });
            }

            this.Locations = new Dictionary<int, string>();
            var assetLoader = new DelegateUIAssetLoader();
            assetLoader.LoadUIPackageBytesAsyncHandlerImpl = LoadUIPackageAsyncHandler;
            assetLoader.LoadUIPackageBytesHandlerImpl = this.LoadUIPackageSyncInner;
            assetLoader.LoadTextureAsyncHandlerImpl = LoadTextureAsyncHandler;
            assetLoader.UnloadTextureHandlerImpl = this.UnloadAssetInner;
            assetLoader.LoadAudioClipAsyncHandlerImpl = LoadAudioClipAsyncHandler;
            assetLoader.UnloadAudioClipHandlerImpl = this.UnloadAssetInner;

            this.AssetLoader = assetLoader;

            byte[] mappingData = ResManager.Instance.LoadRawFileDataSync("UIPackageMapping");
            this.PackageHelper = new UIPackageMapping(mappingData);

            this.UIAssetManager = new UIAssetManager();
            this.UIAssetManager.Initialize(this);
        }

        public UniTask<GObject> CreateObjectAsync(string pkgName, string resName)
        {
            var utcs = new UniTaskCompletionSource<GObject>();

            UIPackage.CreateObjectAsync(pkgName, resName, result =>
            {
                bool succ = utcs.TrySetResult(result);
            });
            return utcs.Task;
        }

        public GObject CreateObject(string pkgName, string resName)
        {
            return UIPackage.CreateObject(pkgName, resName);
        }

        public void UnloadUnusedUIPackages()
        {
            UIPackage.RemoveUnusedPackages();
        }

        public void Destroy()
        {
            this.UIAssetManager.Dispose();
            this.UIAssetManager = null;
            this.AssetLoader = null;

            // if (ResComponent.Instance != null && !ResComponent.Instance.IsDisposed)
            // {
            //     foreach (string location in this.Locations.Values)
            //     {
            //         ResourceService.Instance.UnloadAsset(location);
            //     }
            // }
            foreach (string location in this.Locations.Values)
            {
                ResManager.Instance.UnloadAsset(location);
            }

            this.Locations.Clear();
        }

        private void LoadUIPackageSyncInner(string packageName, out byte[] bytes, out string assetNamePrefix)
        {
            string location = "{0}{1}".Fmt(packageName, "_fui");
            byte[] descData = ResManager.Instance.LoadRawFileDataSync(location);
            bytes = descData;
            assetNamePrefix = packageName;
        }

        private async UniTask LoadUIPackageAsyncInner(string packageName, LoadUIPackageBytesCallback callback)
        {
            string location = "{0}{1}".Fmt(packageName, "_fui");
            byte[] descData = await ResManager.Instance.LoadRawFileDataAsync(location);
            callback(descData, packageName);
        }

        private async UniTask LoadTextureAsyncInner(string assetName, LoadTextureCallback callback)
        {
            Texture res = await ResManager.Instance.LoadAssetAsync<Texture>(assetName);

            if (res != null)
                this.Locations[res.GetInstanceID()] = assetName;

            callback(res);
        }

        private async UniTask LoadAudioClipAsyncInner(string assetName, LoadAudioClipCallback callback)
        {
            AudioClip res = await ResManager.Instance.LoadAssetAsync<AudioClip>(assetName);

            if (res != null)
                this.Locations[res.GetInstanceID()] = assetName;

            callback(res);
        }

        private void UnloadAssetInner(UnityEngine.Object obj)
        {
            if (obj == null)
                return;

            int instanceId = obj.GetInstanceID();
            if (!this.Locations.TryGetValue(instanceId, out string location))
                return;

            this.Locations.Remove(instanceId);

            // if (ResComponent.Instance != null && !ResComponent.Instance.IsDisposed)
            // {
            //     ResourceService.Instance.UnloadAsset(location);
            // }
            ResManager.Instance.UnloadAsset(location);
        }
    }
}