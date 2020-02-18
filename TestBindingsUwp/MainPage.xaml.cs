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
    }
}
