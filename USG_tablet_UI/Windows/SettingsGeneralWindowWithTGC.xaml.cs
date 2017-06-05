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
using System.Windows.Shapes;

namespace USG_tablet_UI
{
    /// <summary>
    /// Interaction logic for SettingsGeneralWindowWithTGC.xaml
    /// </summary>
    public partial class SettingsGeneralWindowWithTGC : Window
    {
        public SettingsGeneralWindowWithTGC()
        {
            InitializeComponent();
            this.Left = 0;
            this.Top = 0;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnTGC1up_Click(object sender, RoutedEventArgs e)
        {
            GlobalSettings.conn.send("tg1u");
        }

        private void btnTGC1down_Click(object sender, RoutedEventArgs e)
        {
            GlobalSettings.conn.send("tg1d");
        }

    }
}
