using MK.Client.HotUpdate;using Core.UI;

namespace MK.Client
{
	[FUIEvent(PanelId.HotUpdatePanel, "HotUpdate", "HotUpdatePanel")]
	public class HotUpdatePanelHandler: UIFormBase
	{
		public FUI_HotUpdatePanel FUIHotUpdatePanel
		{
			get =>(FUI_HotUpdatePanel)this._gameObject;
		}

		public override void RegisterUIEvent()
		{
		}

		public override void OnShow()
		{
		}
	}
}