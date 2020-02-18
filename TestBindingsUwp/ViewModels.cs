using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace TestBindingsUwp
{
    public class PersonVM
    {
        public string Name { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public Color FavoriteColor { get; set;  } = Colors.Transparent;
        public SolidColorBrush FavoriteColorBrush => new SolidColorBrush(this.FavoriteColor);
    }

    public class MainVM
    {
        public ObservableCollection<PersonVM> People { get; } = new ObservableCollection<PersonVM>(new PersonVM[]
        {
            new PersonVM() { Name = "Person 1", FavoriteColor = Colors.Green, Birthday = DateTime.Parse("06/02/1978") },
            new PersonVM() { Name = "Person 2", FavoriteColor = Colors.Yellow, Birthday = DateTime.Parse("11/28/2017") },
            new PersonVM() { Name = "Person 3", FavoriteColor = Colors.Blue, Birthday = DateTime.Parse("05/22/2016") },
        });

        public DateTime StartedTime { get; } = DateTime.Now;
        public string Text => "This is text.";
        public string NumberAsString => "256";
        public string NullString => null;
        public PersonVM NullPerson => null;

        public MainVM()
        {
            int foo = 2;
            Debug.Assert(foo != 0);
        }
    }
}
