using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using WorkersLibrary;

namespace WorkersEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Worker> Workers { get; set; }
        private string connectionString = @"Data Source=ALEX-VAIO-ПК\SQLEXPRESS;Initial Catalog=Workers;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
            Workers = new ObservableCollection<Worker>();

            LoadDrivers();
            LoadManagers();
            
            DataContext = this;
        }

        private void LoadDrivers()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("dbo.select_drivers", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Workers.Add(new Driver(reader["name"].ToString(), Convert.ToInt32(reader["age"]), Convert.ToInt32(reader["snn"]), Convert.ToInt32(reader["hours"]), reader["carType"].ToString()));
            }
            reader.Close();
            connection.Close();
        }

        private void LoadManagers()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("dbo.select_managers", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Workers.Add(new Manager(reader["name"].ToString(), Convert.ToInt32(reader["age"]), Convert.ToInt32(reader["snn"]), Convert.ToInt32(reader["projCount"])));
            }
            reader.Close();
            connection.Close();
        }

        private void workersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Worker worker = (sender as ListBox).SelectedItem as Worker;
            if (worker != null)
            {
                detailsPanel.DataContext = worker;
                if (worker is Driver)
                {
                    manInfo.Visibility = System.Windows.Visibility.Collapsed;
                    drInfo.Visibility = System.Windows.Visibility.Visible;
                }
                if (worker is Manager)
                {
                    manInfo.Visibility = System.Windows.Visibility.Visible;
                    drInfo.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Worker delWorker = workersList.SelectedItem as Worker;
            if (delWorker != null)
            {
                int snn = delWorker.Snn;
                if (delWorker is Driver)
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand command = new SqlCommand("dbo.delete_driver", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("snn", snn);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                if (delWorker is Manager)
                {
                    
                }
                Workers.Remove(delWorker);
                workersList.SelectedIndex = 0;
            }
        }

        private void _BTN_Add_Click(object sender, RoutedEventArgs e)
        {
            //проверка, что создаем водителя
            Driver dr = new Driver(_TB_name.Text, int.Parse(_TB_age.Text), int.Parse(_TB_snn.Text), int.Parse(_TB_hours.Text), _TB_car.Text);
            Workers.Add(dr);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("dbo.insert_driver", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("snn", int.Parse(_TB_snn.Text));
                command.Parameters.AddWithValue("name", _TB_name.Text);
                command.Parameters.AddWithValue("age", int.Parse(_TB_age.Text));
                command.Parameters.AddWithValue("hours", int.Parse(_TB_hours.Text));
                command.Parameters.AddWithValue("carType", _TB_car.Text);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
