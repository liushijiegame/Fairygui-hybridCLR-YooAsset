using Core;
using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;
using YooAsset;

namespace HotUpdate.GameLogic
{
    public class MKSceneManager : Singleton<MKSceneManager>
    {
        private Scene CurrentScene = default(Scene);

        public void Init()
        {
        }

        public async UniTask SceneChange(string sceneName)
        {
            SceneHandle sceneHandle = YooAssets.LoadSceneAsync(sceneName);
            await sceneHandle;
            CurrentScene = sceneHandle.SceneObject;
        }
    }
}