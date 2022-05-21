using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using DotaManager.Models;
using Newtonsoft.Json.Linq;

namespace DotaManager
{
    /// <summary>
    /// Логика взаимодействия для PlayerInfoWindow.xaml
    /// </summary>
    public partial class PlayerInfoWindow : Window
    {
        public PlayerInfoWindow()
        {
            InitializeComponent();
            WebRequestPlayerID();
        }
        
        public void WebRequestPlayerID()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.opendota.com/api/players/123051238");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string sReadData = sr.ReadToEnd();
            response.Close();
            dynamic data = JObject.Parse(sReadData);
            string strName =  data.profile.name;
            label_playerID.Content = strName;
            //string strImage = data.profile.avatarmedium;
            //BitmapImage image = new BitmapImage();
            //image.BeginInit();
            //image.UriSource = new Uri(strImage);
            //image.EndInit();
            //avatar_Image.Source = image;

        }
    }
}
