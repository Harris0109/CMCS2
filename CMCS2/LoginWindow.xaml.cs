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

namespace CMCS2
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Page
    {
        private string validAdminID = "admin";
        private string validPassword = "password";

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string adminID = AdminIDTextBox.Text;
            string password = PasswordBox.Password;

            // Simple authentication check
            if (adminID == validAdminID && password == validPassword)
            {
                // Login successful, open AdminPage
                AdminPage adminPage = new AdminPage();
                this.Content = adminPae;
                 // Close the login window
            }
            else
            {
                MessageBox.Show("Invalid AdminID or Password", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
