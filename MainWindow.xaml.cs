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

namespace GAStephanieLopezeClasses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Item> inventory;
        // A list for the Items!

        ShoppingCart Cart;
        // Shopping Cart Object.
        public MainWindow()
        {
            InitializeComponent();
            PreLoadInventory();
        }

        private void btnAddToCart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTotalTransaction_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lbInventory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
