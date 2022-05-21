using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DotaManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayerIDFind_Click(object sender, RoutedEventArgs e)
        {
            PlayerInfoWindow playerInfoWindow = new PlayerInfoWindow();
            playerInfoWindow.label_playerID.Content = this.PlayerID_textBox.Text;
            playerInfoWindow.Show();
            Close();
        }

        private void MatchIDFind_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
