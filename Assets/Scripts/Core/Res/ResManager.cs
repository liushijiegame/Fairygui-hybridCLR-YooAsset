using System;
using System.Collections.Generic;
using Core;
using Cysharp.Threading.Tasks;
using MK;
using MK.Core.Log;
using UnityEngine;
using UnityEngine.SceneManagement;
using YooAsset;

namespace Mk.Resource
{
    public class ResManager: Singleton<ResManager>
    {
        private ResourcePackage artResourcePackagePackage;
        
        private ResourcePackage fileResourcePackagePackage;
        public string PackageVersion { get; set; }

        public ResourceDownloaderOperation Downloader { get; set; }
        
        public MultiMap<string, AssetHandle> AssetsOperationHandles = new MultiMap<string, AssetHandle>();
        
        public MultiMap<string, SceneHandle> SceneOperationHandles = new MultiMap<string, SceneHandle>();
        
        public Dictionary<HandleBase, Action<float>> HandleProgresses = new Dictionary<HandleBase, Action<float>>();

        public Queue<HandleBase> DoneHandleQueue = new Queue<HandleBase>();
        
        public void Init()
        {
            artResourcePackagePackage = YooAssets.GetPackage("DefaultPackage");
            fileResourcePackagePackage = YooAssets.GetPackage("CodeResPackage");
            
        }
        
        public  void Destroy()
        {
            this.ForceUnloadAllAssets();

            this.PackageVersion = string.Empty;
            this.Downloader = null;
            
            this.AssetsOperationHandles.Clear();
            // this.SubAssetsOperationHandles.Clear();
            this.SceneOperationHandles.Clear();
            this.HandleProgresses.Clear();
            this.DoneHandleQueue.Clear();
            
        }

        public  void Update()
        {
            foreach (var kv in this.HandleProgresses)
            {
                HandleBase handle = kv.Key;
                Action<float> progress = kv.Value;

                if (!handle.IsValid)
                {
                    continue;
                }

                if (handle.IsDone)
                {
                    this.DoneHandleQueue.Enqueue(handle);
                    progress?.Invoke(1);
                    continue;
                }

                progress?.Invoke(handle.Progress);
            }

            while (this.DoneHandleQueue.Count > 0)
            {
                var handle = this.DoneHandleQueue.Dequeue();
                this.HandleProgresses.Remove(handle);
            }
        }

        #region 热更相关

        // public  async UniTask<int> UpdateVersionAsync(int timeout = 30)
        // {
        //     var package = YooAssets.GetPackage("DefaultPackage");
        //     var operation = package.UpdatePackageVersionAsync();
        //     
        //     await operation;
        //
        //     if (operation.Status != EOperationStatus.Succeed)
        //     {
        //         return ErrorCode.ERR_ResourceUpdateVersionError;
        //     }
        //
        //     this.PackageVersion = operation.PackageVersion;
        //     return ErrorCode.ERR_Success;
        // }
        //
        // public  async UniTask<UpdatePackageManifestOperation> UpdateManifestAsync()
        // {
        //     var package = YooAssets.GetPackage("DefaultPackage");
        //     var operation = package.UpdatePackageManifestAsync(this.PackageVersion,false);
        //                 
        //     await operation;
        //
        //     return operation;
        // }
        

        // public  int CreateDownloader()
        // {
        //     int downloadingMaxNum = 10;
        //     int failedTryAgain = 3;
        //     ResourceDownloaderOperation downloader = YooAssets.CreateResourceDownloader(downloadingMaxNum, failedTryAgain);
        //     if (downloader.TotalDownloadCount == 0)
        //     {
        //         MkLog.Info("没有发现需要下载的资源");
        //     }
        //     else
        //     {
        //         MkLog.Info("一共发现了{0}个资源需要更新下载。".Fmt(downloader.TotalDownloadCount));
        //         this.Downloader = downloader;
        //     }
        //
        //     return ErrorCode.ERR_Success;
        // }

        // public  async UniTask<int> DonwloadWebFilesAsync(
        // DownloaderOperation.OnStartDownloadFile onStartDownloadFileCallback = null, 
        // DownloaderOperation.OnDownloadProgress onDownloadProgress = null,
        // DownloaderOperation.OnDownloadError onDownloadError = null,
        // DownloaderOperation.OnDownloadOver onDownloadOver = null)
        // {
        //     if (this.Downloader == null)
        //     {
        //         return ErrorCode.ERR_Success;
        //     }
        //
        //     // 注册下载回调
        //     this.Downloader.OnStartDownloadFileCallback = onStartDownloadFileCallback;
        //     this.Downloader.OnDownloadProgressCallback = onDownloadProgress;
        //     this.Downloader.OnDownloadErrorCallback = onDownloadError;
        //     this.Downloader.OnDownloadOverCallback = onDownloadOver;
        //     this.Downloader.BeginDownload();
        //     await this.Downloader;
        //
        //     // 检测下载结果
        //     if (this.Downloader.Status != EOperationStatus.Succeed)
        //     {
        //         return ErrorCode.ERR_ResourceUpdateDownloadError;
        //     }
        //
        //     return ErrorCode.ERR_Success;
        // }

        #endregion

        #region 卸载

        // public  void UnloadUnusedAssets()
        // {
        //     ResourcePackage package = YooAssets.GetPackage("DefaultPackage");
        //     package.UnloadUnusedAssets();
        // }

        public  void ForceUnloadAllAssets()
        {
            YooAssets.GetPackage("DefaultPackage").ForceUnloadAllAssets();;
            YooAssets.GetPackage("CodeResPackage").ForceUnloadAllAssets();
        }

        public  void UnloadAsset(string location)
        {
            // if (this == null || this.IsDisposed)
            // {
            //     return;
            // }
            if (this.AssetsOperationHandles.TryGetValue(location, out List<AssetHandle> assetOperationHandle))
            {
                assetOperationHandle[^1].Release();
                assetOperationHandle.RemoveAt(assetOperationHandle.Count - 1);
                if (assetOperationHandle.Count == 0)
                {
                    ObjectPool.Instance.Recycle(assetOperationHandle);
                    this.AssetsOperationHandles.Remove(location);
                }
            }
            else
            {
                MLogger.LogError($"资源{location}不存在");
            }
        }

        #endregion

        #region 异步加载

        public  async UniTask<T> LoadAssetAsync<T>(string location) where T: UnityEngine.Object
        {
            this.AssetsOperationHandles.TryGetValue(location, out List<AssetHandle> handles);

            AssetHandle handle = artResourcePackagePackage.LoadAssetAsync<T>(location);
            if (handles == null)
            {
                List<AssetHandle> list =  ObjectPool.Instance.Fetch<List<AssetHandle>>();
                list.Add(handle);
                this.AssetsOperationHandles.Add(location,list);
            }
            else
            {
                handles.Add(handle);
            }

            await handle;

            return handle.GetAssetObject<T>();
        }

        public  async UniTask<UnityEngine.Object> LoadAssetAsync(string location, Type type)
        {
            AssetHandle handle = artResourcePackagePackage.LoadAssetAsync(location, type);

            if (!this.AssetsOperationHandles.TryGetValue(location, out List<AssetHandle> handles))
            {
                List<AssetHandle> list =  ObjectPool.Instance.Fetch<List<AssetHandle>>();
                list.Add(handle);
                this.AssetsOperationHandles.Add(location, list);
            }
            else
            {
                handles.Add(handle);
            }

            await handle;

            return handle.AssetObject;
        }
        public  async UniTask<UnityEngine.SceneManagement.Scene> LoadSceneAsync(string location, Action<float> progressCallback = null, LoadSceneMode loadSceneMode = LoadSceneMode.Single, bool activateOnLoad = false, uint priority = 100)
        {
            SceneHandle handle = artResourcePackagePackage.LoadSceneAsync(location, loadSceneMode, activateOnLoad, priority);
            if (!this.SceneOperationHandles.TryGetValue(location, out List<SceneHandle> handles))
            {
                List<SceneHandle> list =  ObjectPool.Instance.Fetch<List<SceneHandle>>();
                list.Add(handle);
                this.SceneOperationHandles.Add(location,list);
            }
            else
            {
                handles.Add(handle);
            }

            if (progressCallback != null)
            {
                this.HandleProgresses.Add(handle, progressCallback);
            }

            await handle;

            return handle.SceneObject;
        }

        public  async UniTask<byte[]> LoadRawFileDataAsync(string location)
        {
            var handle = fileResourcePackagePackage.LoadRawFileAsync(location);
            await handle;
            var bytes =  handle.GetRawFileData();
            handle.Release();
            return bytes;
        }

        public  async UniTask<string> LoadRawFileTextAsync(string location)
        {
            var handle = fileResourcePackagePackage.LoadRawFileAsync(location);
            await handle;
            var text =  handle.GetRawFileText();
            handle.Release();
            return text;
        }

        #endregion

        #region 同步加载

        public  T LoadAsset<T>(string location)where T: UnityEngine.Object
        {
            var handle = artResourcePackagePackage.LoadAssetSync<T>(location);
            if (!this.AssetsOperationHandles.TryGetValue(location, out var handles))
            {
                List<AssetHandle> list =  ObjectPool.Instance.Fetch<List<AssetHandle>>();
                list.Add(handle);
                this.AssetsOperationHandles.Add(location,list);
            }
            else
            {
                handles.Add(handle);
            }

            return handle.AssetObject as T;
        }
        
        public  UnityEngine.Object LoadAsset(string location, Type type)
        {
            
            var handle = artResourcePackagePackage.LoadAssetSync(location, type);

            if (!this.AssetsOperationHandles.TryGetValue(location, out var handles))
            {
                List<AssetHandle> list =  ObjectPool.Instance.Fetch<List<AssetHandle>>();
                list.Add(handle);
                this.AssetsOperationHandles.Add(location,list);
            }
            else{
                handles.Add(handle);
            }

            return handle.AssetObject;
        }
        
        public  byte[] LoadRawFileDataSync(string location)
        {
            var handle = fileResourcePackagePackage.LoadRawFileSync(location);
            var data = handle.GetRawFileData();
            handle.Release();
            return data;
        }
        
        public  string LoadRawFileTextSync(string location)
        {
            var handle = fileResourcePackagePackage.LoadRawFileSync(location);
            var text = handle.GetRawFileText();
            handle.Release();
            return text;
        }

        #endregion
        
    }
}