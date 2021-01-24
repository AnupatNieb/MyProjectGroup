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
using MySql.Data.MySqlClient;
using System.Data.SQLite;

namespace Program
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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string cs = @"URI=file:C:/Users/niebz/Desktop/MyProjectGroup/Project กะเพราถาด/Program/Program V.2/Program/Database.db";
            using var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM Employee WHERE name_user ='" + UsernameBox.Text + "'AND password_user ='" + PasswordBox.Password + "'";
            using var cmd = new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();


            if (rdr.Read())
            {
                Dashboard Dashboard = new Dashboard();
                Dashboard.Show();
            }

            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลใหม่อีกครั้ง");
                UsernameBox.Text = "";
                PasswordBox.Password = "";
            }
            
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
                
        }
    }
}
