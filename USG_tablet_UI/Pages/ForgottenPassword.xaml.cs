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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace USG_tablet_UI.Pages
{
    /// <summary>
    /// Interaction logic for ForgottenPassword.xaml
    /// </summary>
    public partial class ForgottenPassword : Page
    {
        public ForgottenPassword()
        {
            InitializeComponent();
        }

        private void rctgZaloguj_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages\\Logowanie.xaml", UriKind.Relative));
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages\\Logowanie.xaml", UriKind.Relative));
        }
    }
}
