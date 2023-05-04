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
using GameLauncher.Pages;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using GameLauncher.Database;
using GameLauncher.Windows;

namespace GameLauncher.Pages
{
    /// <summary>
    /// Логика взаимодействия для Develop.xaml
    /// </summary>
    public partial class Develop : Window
    {
        public Develop()
        {
            InitializeComponent();
        }

        private void CartB_Click(object sender, RoutedEventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();
        }

        private void MinimizeLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        private void AccountB_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();
        }

        private void ShopB_Click(object sender, RoutedEventArgs e)
        {
            Shop shop = new Shop();
            shop.Show();
            this.Close();
        }

        private void GamesB_Click(object sender, RoutedEventArgs e)
        {
            Games games = new Games();
            games.Show();
            this.Close();
        }

        private void CloseLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Открытие окна добавления игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddGame_Click(object sender, RoutedEventArgs e)
        {
            DevelopGame developGame = new DevelopGame();
            developGame.Show();
        }

        /// <summary>
        /// Отчет по выложенным играм
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RepCurGame_Click(object sender, RoutedEventArgs e)
        {
            RepForGames repForGames= new RepForGames();
            repForGames.Show();
            this.Close();
        }

        private void EditGamee_Click(object sender, RoutedEventArgs e)
        {
            EditGame editGame = new EditGame();
            editGame.Show();
        }
    }
}
