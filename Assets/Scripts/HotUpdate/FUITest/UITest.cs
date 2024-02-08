using Core;
using Core.UI;
using Cysharp.Threading.Tasks;
using HotUpdate.GameLogic;
using MK.Client;

public class UITest : Singleton<UITest>
{
    public void Init()
    {
        UniTask.Void(async () =>
        {
            await MKSceneManager.Instance.SceneChange("Lobby");
            await UIManager.Instance.ShowPanelAsync(PanelId.LobbyPanel,UIPanelType.Other);
        }); 
    }

}
