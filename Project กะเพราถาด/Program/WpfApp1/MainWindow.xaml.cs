using MySql.Data.MySqlClient;
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

namespace WpfApp1
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

        //ปุ่มปิดโปรแกรม
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //ปุ่มล็อกอิน
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //เชื่อมต่อฐานข้อมูล MySQL
            string sql = "SELECT * FROM `testtable` WHERE username ='"+ UsernameBox.Text + "' AND password ='"+ PasswordBox.Password+"'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=test;password=123456;database=testdatabase");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            //ตรวจสอบชื่อผู้ใช้และรหัสผ่าน
            if (reader.Read())
            {
                MessageBox.Show("คุณได้เข้าสู้ระบบ");
                MainMenu MainMenu = new MainMenu();
                MainMenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง"+System.Environment.NewLine+"กรุณากรอกใหม่อีกครั้ง");
                UsernameBox.Clear();
                PasswordBox.Clear();
            }
        }

        //กด Enter
        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click_1(sender, e);
            }
        }
    }
}
