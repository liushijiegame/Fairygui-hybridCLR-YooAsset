using System.Collections.Generic;
using System.IO;
using MK;

namespace FUIEditor
{
    public static class FUIPackageHelperSpawner
    {
        public static void GenerateMappingFile()
        {
            var ids = new List<string>();
            var names = new List<string>();
            foreach (PackageInfo packageInfo in FUICodeSpawner.PackageInfos.Values)
            {
                ids.Add(packageInfo.Id);
                names.Add(packageInfo.Name);
            }
            
            ByteBuf byteBuf = new ByteBuf();
            byteBuf.WriteInt(ids.Count);
            for (int i = 0; i < ids.Count; i++)
            {
                byteBuf.WriteString(ids[i]);
                byteBuf.WriteString(names[i]);
            }
            
            string filePath = $"../hybridclr-yooasset-game/Assets/GameArt/FUI/UIPackageMapping.bytes";
            using FileStream fs = new FileStream(filePath, FileMode.Create);
            fs.Write(byteBuf.Bytes, 0, byteBuf.Bytes.Length);
        }
    }
}