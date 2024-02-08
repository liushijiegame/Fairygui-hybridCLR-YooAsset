/** This is an automatically generated class by FUICodeSpawner. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MK.Client.Map
{
	public partial class FUI_BattlePanel: GComponent
	{
		public GButton AddBtn;
		public GTextField NumText;
		public const string URL = "ui://u6p0c2cvk2hm0";
		public static FUI_BattlePanel CreateInstance()
		{
			return (FUI_BattlePanel)UIPackage.CreateObject("Map", "BattlePanel");
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			AddBtn = (GButton)GetChildAt(2);
			NumText = (GTextField)GetChildAt(3);
		}
	}
}
