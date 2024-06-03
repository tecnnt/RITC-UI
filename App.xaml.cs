using RITC_UI.Model;
using System.Configuration;
using System.Data;
using System.Windows;

namespace RITC_UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            await SearchMap.InitMap();
        }
    }

}
