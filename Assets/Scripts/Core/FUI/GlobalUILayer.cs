using FairyGUI;
using UnityEngine;

namespace Core.UI
{
    public enum UIPanelType
    {
        Top, // 顶部
        Mid,//中间
        Bottom, //底部
        PopUp, // 弹出窗口
        Other, //其他窗口
    }

    public class GlobalUILayer : Singleton<GlobalUILayer>
    {
        public Transform Global;
        public Transform Unit { get; set; }
        public GRoot GRoot { get; set; }
        private GComponent _topGRoot;
        private GComponent _midGRoot;
        public GComponent _bottomGRoot;
        private GComponent _popUpGRoot;
        private GComponent _otherGRoot;
        public Transform Sounds { get; set; }
        public GComponent GetGRootLayer(UIPanelType uiPanelType)
        {
            switch (uiPanelType)
            {
                case UIPanelType.Top:
                    return _topGRoot;
                case UIPanelType.Mid:
                    return _midGRoot;
                case UIPanelType.Bottom:
                    return _bottomGRoot;
                case UIPanelType.PopUp:
                    return _popUpGRoot;
                case UIPanelType.Other:
                    return _otherGRoot;
                default:
                    return null;
            }
        }

        public void Init()
        {
            this.Global = GameObject.Find("/Global").transform;
            this.Unit = GameObject.Find("/Global/Unit").transform;

            this.GRoot = GRoot.inst;

            this._topGRoot = CreateRoot("TopGRoot");
            this._bottomGRoot = CreateRoot("BottomGRoot");
            this._popUpGRoot = CreateRoot("PopUpGRoot");
            this._otherGRoot = CreateRoot("OtherGRoot");

            this.Sounds = CreateSoundRoot();
        }


        private GComponent CreateRoot(string name)
        {
            GComponent gComponent = new GComponent();
            gComponent.gameObjectName = name;
            gComponent.opaque = false;
            GRoot.inst.AddChild(gComponent);
            return gComponent;
        }

        private Transform CreateSoundRoot()
        {
            GameObject gameObject = new GameObject("SoundsRoot");
            gameObject.transform.SetParent(Global, false);
            return gameObject.transform;
        }
    }
}