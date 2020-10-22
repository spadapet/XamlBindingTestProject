using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace TestBindings
{
    internal partial class MainWindow : Window
    {
        public MainVM ViewModel { get; }

        public MainWindow()
        {
            // Binding.AddTargetUpdatedHandler(this, (object source, DataTransferEventArgs args) => Debug.WriteLine(args));

            this.ViewModel = new MainVM();
            InitializeComponent();

            CheckBox check = new CheckBox();
            this.rootGrid.Children.Add(check);
            BindingOperations.SetBinding(check, CheckBox.IsCheckedProperty, new Binding("BadCheckedPath"));
        }

        private void OnNewPerson(object sender, RoutedEventArgs args)
        {
            this.ViewModel.People.Add(new PersonVM() { Name = "New Person" });
        }

        private void OnClearPeople(object sender, RoutedEventArgs args)
        {
            this.ViewModel.People.Clear();
        }
    }
}
