using System;
using System.Collections.Generic;
using Core;
using Core.UI;
using MK.Client;
using MK.Core.Log;
using UnityEngine.EventSystems;

namespace MK
{
    public class FUICollectionService : Singleton<FUICollectionService>
    {
        public readonly Dictionary<PanelId, UIFormBase> UIEventHandlers = new Dictionary<PanelId, UIFormBase>();
        public readonly Dictionary<PanelId, PanelInfo> PanelIdInfoDict = new Dictionary<PanelId, PanelInfo>();

        public bool isClicked { get; set; }

        public void Init()
        {
            this.UIEventHandlers.Clear();
            this.PanelIdInfoDict.Clear();

            foreach (Type v in AttributeService.Instance.GetTypes(typeof(FUIEventAttribute)))
            {
                FUIEventAttribute attr =
                    v.GetCustomAttributes(typeof(FUIEventAttribute), false)[0] as FUIEventAttribute;
                this.UIEventHandlers.Add(attr.PanelId, Activator.CreateInstance(v) as UIFormBase);
                this.PanelIdInfoDict.Add(attr.PanelId, attr.PanelInfo);
            }
        }

        public UIFormBase GetUIEventHandler(PanelId panelId)
        {
            if (this.UIEventHandlers.TryGetValue(panelId, out UIFormBase handler))
            {
                return handler;
            }

            MLogger.LogError($"panelId : {panelId} is not have any uiEvent");
            return null;
        }

        public PanelInfo GetPanelInfo(PanelId panelId)
        {
            if (this.PanelIdInfoDict.TryGetValue(panelId, out PanelInfo panelInfo))
            {
                return panelInfo;
            }

            MLogger.LogError($"panelId : {panelId} is not have any panelInfo");
            return default;
        }

        public void Destroy()
        {
            this.UIEventHandlers.Clear();
            this.PanelIdInfoDict.Clear();
            this.isClicked = false;
        }
    }

    public struct PanelInfo
    {
        public PanelId PanelId;

        public string PackageName;

        public string ComponentName;
    }
}