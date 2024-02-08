using System.IO;
using System.Text;
using MK;

namespace FUIEditor
{
    public static class FUIPanelHandlerSpawner
    {
        public static void SpawnPanelHandler(string packageName, ComponentInfo componentInfo, VariableInfo variableInfo = null)
        {
            string panelName = componentInfo.NameWithoutExtension;
            
            string fileDir = "{0}/{1}".Fmt(FUICodeSpawner.HotfixViewCodeDir, packageName);
            if (!Directory.Exists(fileDir))
            {
                Directory.CreateDirectory(fileDir);
            }
          
            // 删除原来的 handler 类。
            string duplicateFilePath = "{0}/{1}Handler.cs".Fmt(fileDir, panelName);
            if (File.Exists(duplicateFilePath))
            {
                return;
                // File.Delete(duplicateFilePath);
            }

            string filePath = "{0}/{1}Handler.cs".Fmt(fileDir, panelName);
            // Debug.Log("Spawn EventHandler {0}".Fmt(filePath));

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("using MK.Client.{0};",packageName);
            sb.AppendLine("using Core.UI;");
            sb.AppendLine();
            sb.AppendFormat("namespace {0}", FUICodeSpawner.NameSpace);
            sb.AppendLine();
            sb.AppendLine("{");
            sb.AppendFormat("\t[FUIEvent(PanelId.{0}, \"{1}\", \"{0}\")]", panelName, packageName);
            sb.AppendLine();
            sb.AppendFormat("\tpublic class {0}Handler: UIFormBase", panelName);
            sb.AppendLine();
            sb.AppendLine("\t{");

            sb.AppendFormat("\t\tpublic FUI_{0} FUI{0}",panelName);
            sb.AppendLine();
            sb.AppendLine("\t\t{");
            sb.AppendFormat("\t\t\tget =>(FUI_{0})this._gameObject;",panelName);
            sb.AppendLine();
            sb.AppendLine("\t\t}");
            
            sb.AppendLine();
            sb.AppendFormat("\t\tpublic override void RegisterUIEvent()");
            sb.AppendLine();
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t}");

            sb.AppendLine();
            sb.AppendFormat("\t\tpublic override void OnShow()");
            sb.AppendLine();
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t}");
            
            sb.AppendLine("\t}");
            sb.Append("}");
            
            using FileStream fs = new FileStream(filePath, FileMode.Create);
            using StreamWriter sw = new StreamWriter(fs);
            sw.Write(sb.ToString());
        }

    }
}