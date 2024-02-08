using System;
using System.Collections.Generic;
using Core.Pool;
using FairyGUI;

namespace Core.UI
{
    public abstract class UIFormBase
    {
        public GComponent _gameObject;
        public bool IsPreLoad
        {
            get
            {
                return this._gameObject != null;
            }
        }
        public object UserData { get; set; }
        public abstract void RegisterUIEvent();
        public abstract void OnShow();
    }
}