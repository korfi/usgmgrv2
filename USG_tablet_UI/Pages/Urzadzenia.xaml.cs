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
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace USG_tablet_UI
{
    /// <summary>
    /// Logika interakcji dla klasy Urzadzenia.xaml
    /// </summary>
    public partial class Urzadzenia : Page
    {

        public Urzadzenia()
        {
            InitializeComponent();
            GlobalSettings.currentPage = "Urzadzenia";
            GlobalSettings.vh = new VideoHandler(imgVideo);
            GlobalSettings.vh.connect(GlobalSettings.uScanIP);          
            GlobalSettings.conn = new TCPconnection(GlobalSettings.uScanIP, 13000);
            //GlobalSettings.paramListener = new TCPlistener(12000);
            //GlobalSettings.paramListener.connect();
            GlobalSettings.reader = new StreamReader(GlobalSettings.clientSocket.GetStream());
            if (GlobalSettings.gainRefreshTimer == null)
            {            
                GlobalSettings.gainRefreshTimer = new DispatcherTimer();
                GlobalSettings.gainRefreshTimer.Tick += new EventHandler(refreshGain);
                GlobalSettings.gainRefreshTimer.Interval = new TimeSpan(0, 0, 0, 0, 500);

            }
            //GlobalSettings.gainRefreshTimer.Start(); 
            refreshGain();
        }

        private void btnWstecz_Click(object sender, RoutedEventArgs e)
        {
            GlobalSettings.disconnectSocketStream();
            this.NavigationService.Navigate(new Uri("Pages\\StartPage.xaml", UriKind.Relative));
        }

        private void btnFreeze_Click(object sender, RoutedEventArgs e)
        {
            GlobalSettings.conn.send("frze");
        }

        private void btnGainUp_Click(object sender, RoutedEventArgs e)
        {
            GlobalSettings.conn.send("gaup");
            refreshGain();
        }

        private void btnGainDown_Click(object sender, RoutedEventArgs e)
        {
            GlobalSettings.conn.send("gadn");
            refreshGain();
        }

        private void btn8bit_Click(object sender, RoutedEventArgs e)
        {
            GlobalSettings.conn.send("8bgr");
        }

        private void refreshGain(object sender, EventArgs e)
        {
            if (GlobalSettings.gainRequestCompleted == true)
            {
                GlobalSettings.gainRequestCompleted = false;
                GlobalSettings.conn.send("ggai");
                new Thread(() =>
                {
                    try
                    {
                        Thread.CurrentThread.IsBackground = true;
                        string content = GlobalSettings.reader.ReadLine();
                        this.lblGain.Dispatcher.Invoke((Action)delegate { lblGain.Content = content; });
                        GlobalSettings.gainRequestCompleted = true;
                    }
                    catch (Exception ex) { GlobalSettings.gainRequestCompleted = true; };
                }).Start();
            }
        }

        private void refreshGain()
        {
            if (GlobalSettings.gainRequestCompleted == true)
            {
                GlobalSettings.gainRequestCompleted = false;
                GlobalSettings.conn.send("ggai");
                new Thread(() =>
                {
                    try
                    {
                        Thread.CurrentThread.IsBackground = true;
                        string content = GlobalSettings.reader.ReadLine();
                        this.lblGain.Dispatcher.Invoke((Action)delegate { lblGain.Content = content; });
                        GlobalSettings.gainRequestCompleted = true;
                    }
                    catch (Exception ex) { GlobalSettings.gainRequestCompleted = true; };
                }).Start();
            }
        }
    }
}
