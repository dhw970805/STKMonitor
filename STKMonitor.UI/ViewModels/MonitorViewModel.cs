using Prism.Mvvm;
using STKMonitor.UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
namespace STKMonitor.UI.ViewModels
{
    
    public class MonitorViewModel:BindableBase
    {
        private ObservableCollection<Ruler> ruler;
        public ObservableCollection<Ruler> Rulersss
        {
            get
            {
                return ruler;
            }
            set
            {
                SetProperty(ref ruler, value);
            }
        }
        private ObservableCollection<ArmSystem> armSystems;
        public ObservableCollection<ArmSystem> ArmSystems
        {
            get
            {
                return armSystems;
            }
            set
            {
                SetProperty(ref armSystems, value);
            }
        }
        public MonitorViewModel()
        {
            armSystems = new ObservableCollection<ArmSystem>()
            {
                new ArmSystem(){Camp=Camps.Red, Name="F22",
                    Behaviours=new List<Behaviour>(){new Behaviour() { Camp=Camps.Red, IsDone=true, Name="结束", StartTime=0,LastTime=100},
                    new Behaviour() { Camp=Camps.Red, IsDone=true, Name="结束2", StartTime=100,LastTime=200}}},
                new ArmSystem(){Camp=Camps.Red, Name="F23",
                    Behaviours=new List<Behaviour>(){new Behaviour() { Camp=Camps.Red, IsDone=true, Name="开始", StartTime=0, LastTime = 200,}}}
            };
            //ruler = new ObservableCollection<Ruler>()
            //{
            //    new Ruler(){ Length = 20, Seconds = 100.ToString() }
            //};
            InitRuler();
        }

        void InitRuler()
        {
            ruler = new ObservableCollection<Ruler>();
            int padding = 3;
            for (int i = 0; i < 300; i++)
            {
                int second = padding * i + i;
                int length = 10;
                if(i%5==0)
                {
                    length = 20;
                }
                ruler.Add(new Ruler(){ Length = length, Seconds = second });
            }
        }
    }
}

