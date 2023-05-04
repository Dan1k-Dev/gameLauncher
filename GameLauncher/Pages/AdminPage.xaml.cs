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
using System.Windows.Shapes;

namespace GameLauncher.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AddExcel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MinimizeLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        private void CloseLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Develop develop = new Develop();
            develop.Show();
            this.Close();
        }
    }
}
