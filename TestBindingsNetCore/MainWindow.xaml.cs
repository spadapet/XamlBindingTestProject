using System.Diagnostics;
using System.Windows;
using System.Windows.Data;

namespace TestBindings
{
    internal partial class MainWindow : Window
    {
        public MainVM ViewModel { get; }

        public MainWindow()
        {
            Binding.AddTargetUpdatedHandler(this, (object source, DataTransferEventArgs args) =>
            {
                Debug.WriteLine(args);
            });

            this.ViewModel = new MainVM();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel.People.Add(new PersonVM() { Name = "New Person" });
        }
    }
}
