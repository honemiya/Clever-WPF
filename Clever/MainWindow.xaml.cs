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

namespace Clever
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataViewModel viewModel = new DataViewModel();
        public MainWindow()
        {
            InitializeComponent();
            
            this.DataContext = viewModel;
            
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Save();
            this.Close();
        }
    }

}
