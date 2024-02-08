using System;
using System.Collections.Generic;
using Core.FUI;
using Core.Singleton;
using Core.UI.Tool;
using Cysharp.Threading.Tasks;
using FairyGUI;
using GameFramework;
using MK;
using MK.Client;
using MK.Core.Log;
using UnityEngine;

namespace Core.UI
{
    public class UIManager : Singleton<UIManager>
    {
        public void Init()
        {
            FUIBinder.BindAll();
        }

        public void ShowPanel(string pkg,string name,UIPanelType layer, object userData = null)
        {
            GlobalUILayer.Instance.GetGRootLayer(layer).AddChild(UIPackage.CreateObject(pkg, name).asCom);
        }

       
        public async UniTask ShowPanelAsync(PanelId panelId, UIPanelType layer, object userData = null)
        {
            UIFormBase uiForm = FUICollectionService.Instance.GetUIEventHandler(panelId);
            uiForm.UserData = userData;
            if (uiForm.IsPreLoad)
            {
                uiForm._gameObject.RemoveFromParent();
            }
            else
            {
                uiForm._gameObject = await LoadFUIEntitysAsync(panelId);
            }

            if (!uiForm._gameObject.visible)
            {
                uiForm._gameObject.visible = true;
            }

            GlobalUILayer.Instance.GetGRootLayer(layer).AddChild(uiForm._gameObject);
            //TODO 执行
            uiForm.RegisterUIEvent();
            uiForm.OnShow();
        }

        /// <summary>
        /// 异步加载
        /// </summary>
        private  async UniTask<GComponent> LoadFUIEntitysAsync(PanelId panelId)
        {
            if (!FUICollectionService.Instance.PanelIdInfoDict.TryGetValue(panelId, out PanelInfo panelInfo))
            {
                MLogger.LogError($"{panelId} panelInfo is not Exist!");
                return null;
            }

            // 创建组件
            GComponent gComponent = (await FUIAssetManager.Instance
                .CreateObjectAsync(panelInfo.PackageName, panelInfo.ComponentName)).asCom;
            return gComponent;
        }

        public void HidePanel(PanelId panelId)
        {
            if (!FUICollectionService.Instance.UIEventHandlers.TryGetValue(panelId, out UIFormBase uiForm))
            {
                return;
            }

            if (uiForm.IsPreLoad)
            {
                uiForm._gameObject.visible = false;
            }
        }
    }
}