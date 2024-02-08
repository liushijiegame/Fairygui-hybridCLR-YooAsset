using FUIEditor;
using MK;
using UnityEditor;
using UnityEngine;

public class MKToolWindow : EditorWindow
{
    
    private string fairyGUIXMLPath;
    private MKToolWindow window;
    [MenuItem("MKTools/Mk tool Window",priority = 100)]
    public static void ShowReadExcelWindow()
    {
        MKToolWindow window = GetWindow<MKToolWindow>(true);
        window.Show();
        window.minSize = new Vector2(475,475);
    }

    private void OnGUI()
    {
        GUILayout.Label("");
        GUILayout.Label("FairyGUI工具");
        GUIContent guiContent = new GUIContent("FairyGUI语言文件XML路径：", "在 FairyGUI 里生成");
        EditorGUI.BeginChangeCheck();
        string xmlPath = EditorGUILayout.TextField(guiContent, fairyGUIXMLPath);
        if (EditorGUI.EndChangeCheck())
        {
            fairyGUIXMLPath = xmlPath;
        }
        if (GUILayout.Button("导出 FairyGUI 多语言"))
        {
            if (FUICodeSpawner.Localize(fairyGUIXMLPath))
            {
                ShowNotification("FairyGUI 多语言导出成功！");
            }
            else
            {
                ShowNotification("FairyGUI 多语言导出失败！");
            }
        }
        GUILayout.Space(5);
        if (GUILayout.Button("FUI代码生成"))
        {
            FUICodeSpawner.FUICodeSpawn();
            ShowNotification("FUI代码生成成功！");
        }
    }
    public static void ShowNotification(string tips)
    {
        EditorWindow game = EditorWindow.GetWindow(typeof(MKToolWindow));
        game?.ShowNotification(new GUIContent($"{tips}"),2);
        // Log.Debug(tips);
    }
    
}
