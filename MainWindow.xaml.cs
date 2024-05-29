using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using Newtonsoft.Json;
using RITC_UI.Model;

namespace RITC_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        JsonSerializerSettings jsonSetting = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PackageLoad()
        {
            Package.DataContext = PackageData.Info;
        }

        private void Package_Initialized(object sender, EventArgs e)
        {

        }

        private void Menu_New_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Menu_Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFolderDialog dialog = new OpenFolderDialog();
            dialog.DefaultDirectory = Environment.CurrentDirectory;
            dialog.ShowDialog();
            string selectPath = dialog.FolderName;
            try
            {
                PackageData.Load(selectPath);
                PackageLoad();
            }
            catch (RITC_Exception ritcex)
            {
                MessageBox.Show(ritcex.Message);
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
