using Windows.UI.Xaml.Controls;

namespace TestBindingsUwp
{
    public sealed partial class MainPage : Page
    {
        public MainVM ViewModel { get; }

        public MainPage()
        {
            this.ViewModel = new MainVM();
            this.InitializeComponent();
        }

        private void ButtonClickAdd(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Adding a person");
            this.ViewModel.People.Add(new PersonVM() { Name = "Foobar" });
        }

        private void ButtonClickClear(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Clearing pepole");
            this.ViewModel.People.Clear();
        }
    }
}
