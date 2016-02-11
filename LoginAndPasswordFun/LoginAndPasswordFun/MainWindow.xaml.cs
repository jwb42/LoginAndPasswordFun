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

namespace LoginAndPasswordFun
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Prorgam dedicated to building login and password capability within a WPF application
            //Blah
        }

        private void logInBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!usernameTb.Text.Equals("") && !passwordBoxPB.Password.Equals(""))
            {
                if (usernameTb.Text.Equals("1") && passwordBoxPB.Password.Equals("1"))
                {
                    testImage.Visibility = Visibility.Visible;
                    logInBtn.Visibility = Visibility.Collapsed;
                    logOutBtn.Visibility = Visibility.Visible;
                }
                else

                    MessageBox.Show("Wrong Password");
            }
            else
                MessageBox.Show("Wrong Info");
            }
        }
    }

