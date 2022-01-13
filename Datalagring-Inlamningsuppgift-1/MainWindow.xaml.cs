﻿using Datalagring_Inlamningsuppgift_1.ViewModels;
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

namespace Datalagring_Inlamningsuppgift_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Customer {firstNameText.Text} {lastNameText.Text} has been added!");
        }

        private void registerCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new RegisterCustomerModel();
        }

        private void registerErrandButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new RegisterErrandModel();
        }
    }
}
