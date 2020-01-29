using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Data;
//using System.Windows.Data.Debugging;
using System.Windows.Diagnostics;
using System.Windows.Media;

namespace TestBindings
{
    internal class PersonVM
    {
        public string Name { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public Color FavoriteColor { get; set;  } = Colors.Transparent;
        public SolidColorBrush FavoriteColorBrush => new SolidColorBrush(this.FavoriteColor);
    }

    internal class MainVM
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

    //internal class BindingInfo : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    private BindingInfoEventArgs args;
    //    public string DataContextType => (this.args.BindingExpression as BindingExpression)?.DataItem?.GetType().FullName ?? "<null>";
    //    public string DataContextPath => (this.args.BindingExpression as BindingExpression)?.ParentBinding?.Path?.Path ?? "<null>";
    //    public string SourceType => this.args.ValueSource?.GetType().FullName ?? "<null>";
    //    public string SourceValue => this.args.ValueName ?? string.Empty;
    //    public string TargetType => this.args.BindingExpression.Target?.GetType().FullName ?? "<null>";
    //    public string TargetProperty => this.args.BindingExpression.TargetProperty?.Name ?? "<null>";
    //    public string Status => this.args.BindingExpression.Status.ToString();
    //    public int LineNumber => this.args.XamlSourceInfo?.LineNumber ?? 0;
    //    public int LinePosition => this.args.XamlSourceInfo?.LinePosition ?? 0;
    //    public string SourceFile => this.args.XamlSourceInfo?.SourceUri.ToString() ?? "<no source>";

    //    public BindingInfo(BindingInfoEventArgs args)
    //    {
    //        this.args = args;
    //    }

    //    private void OnPropertyChanged(string name)
    //    {
    //        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //    }
    //}
}
