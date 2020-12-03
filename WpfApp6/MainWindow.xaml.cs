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

namespace WpfApp6
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            varA.Clear();
            varB.Clear();
            Result.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int x, y, S;
                x = int.Parse(varA.Text);
                y = int.Parse(varB.Text);
                if (Add.IsChecked == true)
                {
                    S = x + y;
                    Result.Text = x + "+" + y + "=" + S;
                }
                if (Sub.IsChecked == true)
                {
                    S = x - y;
                    Result.Text = x + "-" + y + "=" + S;
                }
                if (Mul.IsChecked == true)
                {
                    S = x * y;
                    Result.Text = x + "*" + y + "=" + S;
                }
                if (Div.IsChecked == true)
                {
                    S = x / y;
                    Result.Text = x + "/" + y + "=" + S;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
