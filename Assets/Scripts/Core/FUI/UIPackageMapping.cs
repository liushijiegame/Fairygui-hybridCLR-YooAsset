using System.Collections.Generic;
using FairyGUI.Dynamic;
using MK;

namespace Core.UI.Tool
{
    public class UIPackageMapping: IUIPackageHelper
    {
        private readonly Dictionary<string, string> m_PackageIdToNameMap;

        public UIPackageMapping(byte[] mappingData)
        {
            ByteBuf byteBuf = new ByteBuf(mappingData);
            int count = byteBuf.ReadInt();

            Dictionary<string, string> mappingDict = new Dictionary<string, string>(count);
            for (int i = 0; i < count; i++)
            {
                mappingDict.Add(byteBuf.ReadString(), byteBuf.ReadString());
            }
            
            m_PackageIdToNameMap = mappingDict;
        }
        
        public string GetPackageNameById(string id)
        {
            return m_PackageIdToNameMap.TryGetValue(id, out var packageName) ? packageName : null;
        }
    }
}