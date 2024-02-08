using System;
using MK.Client;

namespace MK
{
    
    [AttributeUsage(AttributeTargets.Class)]
    public class FUIEventAttribute: FUIBaseAttribute
    {
        public PanelId PanelId
        {
            get;
        }

        public PanelInfo PanelInfo
        {
            get;
        }

        public FUIEventAttribute(PanelId panelId, string packageName, string componentName)
        {
            this.PanelId = panelId;
            this.PanelInfo = new PanelInfo() { PanelId = panelId, PackageName = packageName, ComponentName = componentName };
        }
    }
}