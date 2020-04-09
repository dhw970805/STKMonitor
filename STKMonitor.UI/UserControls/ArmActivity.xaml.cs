using STKMonitor.UI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace STKMonitor.UI.UserControls
{
    /// <summary>
    /// ArmActivity.xaml 的交互逻辑
    /// </summary>
    public partial class ArmActivity : UserControl
    {
        //public static readonly DependencyProperty ActivitySourceProperty=
        //    DependencyProperty.Register("ActivitySource", typeof(ObservableCollection<object>), typeof(ArmActivity));


        //public List<Behaviour> ActivitySource
        //{
        //    get { return (List<Behaviour>)GetValue(ActivitySourceProperty); }
        //    set { SetValue(ActivitySourceProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty ActivitySourceProperty =
        //    DependencyProperty.Register("ActivitySource", typeof(List<Behaviour>), typeof(ArmActivity));


        public List<Behaviour> Items
        {
            get => (List<Behaviour>)GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register(nameof(Items), typeof(List<Behaviour>), typeof(ArmActivity),
                new PropertyMetadata(null, PropertyChangedCallback, null));

        private static void PropertyChangedCallback(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            if (args.NewValue is List<Behaviour> newValue)
            {
                var control = obj as ArmActivity;
                //control.actCanvas.Children;
                //actCanvas.Children.Add(new TextBox() { Text= ((Behaviour)args.NewValue).Name});
                //try
                //{
                //    var control = obj as UC_FoodsPanel;
                //    control.SpFoods.Children.Clear();

                //    foreach (var item in newValue)
                //    {
                //        control.SpFoods.Children.Add(item);
                //    }
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.ToString());
                //    MessageBox.Show($"载入数据出错：{ex.Message}");
                //}
            }
        }

        //public ObservableCollection<Behaviour> Behaviours
        //{
        //    get { return (ObservableCollection<Behaviour>)GetValue(ActivitySourceProperty); }
        //    set { SetValue(ActivitySourceProperty, value); }
        //}

        public ArmActivity()
        {
            InitializeComponent();
            //DataContext = this;
            //DataContext = this;
            //foreach (Behaviour item in ActivitySource)
            //{
            //    aclist.Items.Add(new TextBlock() { Text = item.IsDone.ToString() });
            //}
            //ActivitySource.Cast<Behaviour>();
        }

        
    }
}
