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
using GameLauncher.Windows;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using GameLauncher.Database;
using System.IO;

namespace GameLauncher.Pages
{
    /// <summary>
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        LauncherDbContext context = new LauncherDbContext();

        /// <summary>
        /// При открытии вкладки аккаунта получаем данные профиля
        /// </summary>
        public Account()
        {
            InitializeComponent();

            var reqNick = from l in context.logs //ник
                          orderby l.idLog descending
                          select l.userName;
            string curNick = reqNick.FirstOrDefault();

            var reqDate = from l in context.logs //дата последнего захода
                          orderby l.Date descending
                          select l.Date;

            var reqEmail = context.users.Where(x => x.UserName.Contains(curNick)).Single().Email; //Почта
            var reqBalance = context.users.Where(x => x.UserName.Contains(curNick)).Single().Balance;

            log.Text = $"Последний онлайн: {reqDate.FirstOrDefault()}";
            balance.Text = $"{reqBalance}";
            Nickname.Text = reqNick.FirstOrDefault();
            Email.Text = reqEmail.ToString();
        }

        /// <summary>
        /// Свернуть лаунчер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Закрыть лаунчер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Вкладка корзина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CartB_Click(object sender, RoutedEventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();
        }

        /// <summary>
        /// Вкладка магазин
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShopB_Click(object sender, RoutedEventArgs e)
        {
            Shop shop = new Shop();
            shop.Show();
            this.Close();
        }

        /// <summary>
        /// Вкладка игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GamesB_Click(object sender, RoutedEventArgs e)
        {
            Games games = new Games();
            games.Show();
            this.Close();
        }

        /// <summary>
        /// Выход из аккаунта на страницу авторизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitAcc_Click(object sender, RoutedEventArgs e)
        {
            MainWindow signIn = new MainWindow();
            this.Close();
            signIn.Show();
        }

        /// <summary>
        /// Вывести и открыть отчет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Report_Click(object sender, RoutedEventArgs e)
        {
            RepForBalance forBalance = new RepForBalance(); 
            forBalance.Show();
            this.Close();
        }

        /// <summary>
        /// Редактирование профиля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProf_Click(object sender, RoutedEventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
        }

        /// <summary>
        /// Страница разработчика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DevelopB_Click(object sender, RoutedEventArgs e)
        {
            Develop develop = new Develop();
            develop.Show();
            this.Close();
        }

        private void Replenishment_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            BalanceReplenishment replenishment = new BalanceReplenishment();
            replenishment.Show();
        }
    }
}
