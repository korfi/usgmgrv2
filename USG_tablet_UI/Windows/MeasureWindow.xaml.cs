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
    /// Interaction logic for MeasureWindow.xaml
    /// </summary>
    public partial class MeasureWindow : Window
    {
        public MeasureWindow()
        {
            InitializeComponent();
            this.Left = 0;
            this.Top = 1280-675;
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMarkerA_Click(object sender, RoutedEventArgs e)
        {
            if (imgMarkerA.Visibility == System.Windows.Visibility.Visible)
            {
                imgMarkerA.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (imgMarkerA.Visibility == System.Windows.Visibility.Hidden)
            {
                imgMarkerA.Visibility = System.Windows.Visibility.Visible;
                imgMarkerB.Visibility = System.Windows.Visibility.Hidden;
                imgMarkerC.Visibility = System.Windows.Visibility.Hidden;
                imgMarkerD.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void btnMarkerB_Click(object sender, RoutedEventArgs e)
        {
            if (imgMarkerB.Visibility == System.Windows.Visibility.Visible)
            {
                imgMarkerB.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (imgMarkerB.Visibility == System.Windows.Visibility.Hidden)
            {
                imgMarkerA.Visibility = System.Windows.Visibility.Hidden;
                imgMarkerB.Visibility = System.Windows.Visibility.Visible;
                imgMarkerC.Visibility = System.Windows.Visibility.Hidden;
                imgMarkerD.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void btnMarkerC_Click(object sender, RoutedEventArgs e)
        {
            if (imgMarkerC.Visibility == System.Windows.Visibility.Visible)
            {
                imgMarkerC.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (imgMarkerC.Visibility == System.Windows.Visibility.Hidden)
            {
                imgMarkerA.Visibility = System.Windows.Visibility.Hidden;
                imgMarkerB.Visibility = System.Windows.Visibility.Hidden;
                imgMarkerC.Visibility = System.Windows.Visibility.Visible;
                imgMarkerD.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void btnMarkerD_Click(object sender, RoutedEventArgs e)
        {
            if (imgMarkerD.Visibility == System.Windows.Visibility.Visible)
            {
                imgMarkerD.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (imgMarkerD.Visibility == System.Windows.Visibility.Hidden)
            {
                imgMarkerA.Visibility = System.Windows.Visibility.Hidden;
                imgMarkerB.Visibility = System.Windows.Visibility.Hidden;
                imgMarkerC.Visibility = System.Windows.Visibility.Hidden;
                imgMarkerD.Visibility = System.Windows.Visibility.Visible;
            }
        }

    }
}
