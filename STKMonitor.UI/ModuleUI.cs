using Prism.Ioc;
using Prism.Modularity;
using STKMonitor.UI.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace STKMonitor.UI
{
    public class ModuleUI : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
            //throw new NotImplementedException();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Monitor>();
            //throw new NotImplementedException();
        }
    }
}
