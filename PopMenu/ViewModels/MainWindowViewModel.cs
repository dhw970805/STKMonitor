using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopMenu.ViewModels
{
    public class ItemClass
    {
        public int Top { get; set; }

        public string Name { get; set; }
    }
    class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        public string Title { get; set; } = "监控工具";
        public int Top { get; set; }
        public ObservableCollection<ItemClass> ItemString { get; set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            ItemString = new ObservableCollection<ItemClass>();
            ItemString.Add(new ItemClass() { Name = "1", Top = 20 });
            ItemString.Add(new ItemClass() { Name = "2", Top = 50 });
            //_regionManager.RegisterViewWithRegion("ContentRegion", typeof(Monitor));
        }
    }
}
