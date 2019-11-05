using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TestBindings
{
    /// <summary>
    /// Interaction logic for BindingInfoWindow.xaml
    /// </summary>
    internal partial class BindingInfoWindow : Window
    {
        //public ObservableCollection<BindingInfo> BindingInfos { get; }

        public BindingInfoWindow()
        {
            //this.BindingInfos = new ObservableCollection<BindingInfo>();
            InitializeComponent();
        }
    }
}
