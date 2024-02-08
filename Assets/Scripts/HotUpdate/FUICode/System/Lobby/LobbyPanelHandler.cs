using MK.Client.Lobby;using Core.UI;
using Cysharp.Threading.Tasks;
using HotUpdate.GameLogic;
using UnityEngine.SceneManagement;
using YooAsset;

namespace MK.Client
{
	[FUIEvent(PanelId.LobbyPanel, "Lobby", "LobbyPanel")]
	public class LobbyPanelHandler: UIFormBase
	{
		public FUI_LobbyPanel FUILobbyPanel
		{
			get =>(FUI_LobbyPanel)this._gameObject;
		}

		public override void RegisterUIEvent()
		{
			FUILobbyPanel.EnterMap.AddListnerAsync(CreateScene);
		}

		public override void OnShow()
		{
		}

		public async UniTask CreateScene()
		{
			UniTask.Void(async () =>
			{
                UIManager.Instance.HidePanel(PanelId.LobbyPanel);
				await MKSceneManager.Instance.SceneChange("scene_test");
				await UIManager.Instance.ShowPanelAsync(PanelId.BattlePanel,UIPanelType.Other);
				BattleTest.Instance.Init();
			});
			
		}
		
	}
}