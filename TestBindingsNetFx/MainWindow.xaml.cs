using System;
using System.Windows;
using System.Windows.Media;

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

        private void OnClickAddPerson(object sender, RoutedEventArgs e)
        {
            this.ViewModel.People.Add(new PersonVM()
            {
                Name = $"Person {this.ViewModel.People.Count + 1}",
                FavoriteColor = Colors.Blue,
                Birthday = DateTime.Parse("05/22/2010"),
            });
        }
    }
}
