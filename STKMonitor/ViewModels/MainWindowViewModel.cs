﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Regions;
using STKMonitor.UI.Views;
using STKMonitor.Views;
namespace STKMonitor.ViewModels
{
    class MainWindowViewModel: BindableBase
    {
        private readonly IRegionManager _regionManager;
        public string Title { get; set; } = "监控工具";
        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(Monitor));
        }
    }
}
