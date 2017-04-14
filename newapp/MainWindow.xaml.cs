using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

namespace newapp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string logg { set; get; }
        public string pass { set;  get; }
        private string connected = @"Data Source=ALEX-VAIO-ПК\SQLEXPRESS;Initial Catalog=login_db;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();

        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            string log1 = Login.Text;
            string pas1 = Password.Text;
            
            MD5 md5 = new MD5CryptoServiceProvider();
            pas1 = Encoding.Default.GetString(md5.ComputeHash(Encoding.Default.GetBytes(pas1)));

            SqlConnection qwerty = new SqlConnection(connected);
            SqlCommand com = new SqlCommand("dbo.READPASS", qwerty);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("log", log1);
            qwerty.Open();
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();
            string aaa = reader["PASS"].ToString();
            qwerty.Close();
            if (pas1 == aaa)
            {
                Login.Text = "Успех";
            }
        }
    }
}
