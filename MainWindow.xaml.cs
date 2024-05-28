﻿using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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

        private void Package_Initialized(object sender, EventArgs e)
        {
            var data = JsonConvert.DeserializeObject<RITC_Package>(File.ReadAllText("./Asset/package.json"));
            Package.DataContext = data;
        }
    }
}