using System.Windows;

namespace TestBindingsNetFx
{
    internal partial class MainWindow : Window
    {
        public MainVM ViewModel { get; }

        public MainWindow()
        {
            this.ViewModel = new MainVM();
            this.InitializeComponent();
        }
    }
}
