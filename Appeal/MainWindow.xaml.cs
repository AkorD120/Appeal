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

namespace Appeal
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

        private void BtnChatMenu_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            bgShadow.Visibility = Visibility.Visible;
        }

        private void LeftMenu_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           (sender as Grid).Visibility = Visibility.Hidden;
        }
    }
}
