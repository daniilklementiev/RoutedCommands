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

namespace RoutedCommands
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
        private void CommandBinding_ExecutedR(object sender, ExecutedRoutedEventArgs e)
        {
            button.Background = Brushes.Red;
        }
        private void CommandBinding_ExecutedG(object sender, ExecutedRoutedEventArgs e)
        {
            button.Background = Brushes.Green;
        }
        private void CommandBinding_ExecutedB(object sender, ExecutedRoutedEventArgs e)
        {
            button.Background = Brushes.Blue;
        }
    }

    public class ColorCommands
    {
        static ColorCommands()
        {
            RedCommand = new RoutedCommand("RedCommand", typeof(ColorCommands));
            BlueCommand = new RoutedCommand("BlueCommand", typeof(ColorCommands));
            GreenCommand = new RoutedCommand("GreenCommand", typeof(ColorCommands));
        }

        public static RoutedCommand RedCommand { get;  set; }
        public static RoutedCommand BlueCommand { get;  set; }
        public static RoutedCommand GreenCommand { get;  set; }
    }
}
