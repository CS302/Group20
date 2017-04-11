using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WorkersLibrary;

namespace WorkersEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Worker> Workers { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Workers = new ObservableCollection<Worker>();
            Workers.Add(new Driver("John", 28, 123456, 256, "BMW"));
            Workers.Add(new Driver("Ivan", 38, 456123, 128, "UAZ"));
            Workers.Add(new Manager("Hulk", 58, 789456, 15));
            Workers.Add(new Manager("Linda", 35, 89621, 10));
            Workers.Add(new Manager("Max", 18, 7896412, 8));

            DataContext = this;
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
                Workers.Remove(delWorker);
                workersList.SelectedIndex = 0;
            }
        }
    }
}
