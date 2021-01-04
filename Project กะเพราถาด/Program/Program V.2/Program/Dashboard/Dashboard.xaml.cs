using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Program
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            SubPanel.Content = new DashboardPage();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menu_btn_Click(object sender, RoutedEventArgs e)
        {
            SubPanel.Content = new MenuPage();
        }

        private void dashboard_btn_Click(object sender, RoutedEventArgs e)
        {
            SubPanel.Content = new DashboardPage();
        }
    }
}
