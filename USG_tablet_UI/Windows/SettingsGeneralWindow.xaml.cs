﻿using System;
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
    /// Interaction logic for SettingsGeneralWindow.xaml
    /// </summary>
    public partial class SettingsGeneralWindow : Window
    {
        public SettingsGeneralWindow()
        {
            InitializeComponent();
            GlobalSettings.sideMenuVisible = true;
            this.Left = 0;
            this.Top = 0;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            GlobalSettings.sideMenuVisible = false;
            this.Close();
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            try
            {
                GlobalSettings.sideMenuVisible = false;
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }

    }
}
