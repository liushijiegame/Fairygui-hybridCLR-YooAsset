/** This is an automatically generated class by FUICodeSpawner. Please do not modify it. **/

using System.Collections.Generic;

namespace FairyGUI.Dynamic
{
	public class UIPackageHelper : IUIPackageHelper
	{
		private static readonly Dictionary<string, string> IdToNameDict = new Dictionary<string, string>()
		{
			["vlnfv0q0"] = "Account",
			["vfbq41gf"] = "CharacterCreator",
			["f2boiu4i"] = "Common",
			["3ou6ly1o"] = "ErrorWindow",
			["2f8jqeff"] = "HotUpdate",
		};

		public string GetPackageNameById(string id)
		{
			if (IdToNameDict.TryGetValue(id, out var name))
			{
				return name;
			}

			return null;
		}
	}
}
