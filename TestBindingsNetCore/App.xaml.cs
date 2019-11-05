using System.Windows;
using System.Linq;
//using System.Windows.Data.Debugging;

namespace TestBindings
{
    public partial class App : Application
    {
        public App()
        {
            this.ShutdownMode = ShutdownMode.OnMainWindowClose;

            //BindingDebugging.IsDebuggingEnabled = true;
            //BindingDebugging.BindingInfoEvent += this.OnBindingInfoEvent;
        }

        //private void OnBindingInfoEvent(object sender, BindingInfoEventArgs args)
        //{
        //    BindingInfoWindow window = this.Windows.OfType<BindingInfoWindow>().FirstOrDefault();
        //    if (window == null)
        //    {
        //        window = new BindingInfoWindow();
        //        window.Show();
        //    }

        //    window.BindingInfos.Add(new BindingInfo(args));
        //}
    }
}
