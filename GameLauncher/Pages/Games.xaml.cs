using GameLauncher.Database;
using GameLauncher.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
using Shape = Microsoft.Office.Interop.Word.Shape;
using GameLauncher.Pages;

namespace GameLauncher.Pages
{
    /// <summary>
    /// Логика взаимодействия для Games.xaml
    /// </summary>
    public partial class Games : Window
    {
        LauncherDbContext context = new LauncherDbContext();
        public Games()
        {
            InitializeComponent();

            var userId = from c in context.logs
                         orderby c.idLog descending
                         select c.UserId;
            var UID = userId.FirstOrDefault();

            var gID = context.userGames.Where(x => x.UserID == UID).Select(x => x.GameID).ToList();

            foreach (var game in gID)
            {
                var gameName = context.games.Where(x => x.idGame == game).Single().GameName;
                GameLB.Items.Add(gameName);
            }
        }

        /// <summary>
        /// Запуск игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoGame_Click(object sender, RoutedEventArgs e)
        {
            if (NameGame.Text == "Dotz")
            {
                Process.Start("C:\\Users\\student\\Desktop\\GameLauncher }}\\DOTZ\\DOTZ.exe"); 
                LogGame();
                var date = from g in context.logsGames //Выводим дату последнего запуска
                           where g.NameGame == NameGame.Text
                           orderby g.Date descending
                           select g.Date;
                DateLast.Text = date.FirstOrDefault().ToString();
            }
            else
            {
                MessageGameDevelop develop = new MessageGameDevelop();
                develop.Show();
                LogGame();
                var date = from g in context.logsGames
                           where g.NameGame == NameGame.Text
                           orderby g.Date descending 
                           select g.Date;
                DateLast.Text = date.FirstOrDefault().ToString();
            }
        }

        /// <summary>
        /// Формирование отчета о последнем запуске конкретной игры, если она запускалась
        /// </summary>
        internal void LogGame()
        {
            DateTime date = DateTime.Now;
            string curDate = date.ToString("dd/M/yyyy hh:mm"); //Получение текущей даты

            var gameName = context.games.Where(p => p.GameName.Contains(NameGame.Text)).Single().GameName;
            var gameId = context.games.Where(p => p.GameName.Contains(NameGame.Text)).Single().idGame;

            var req = new LogsGames()
            {
                GameID = gameId,
                Date = curDate.ToString(),
                NameGame = gameName
            };
            context.logsGames.Add(req);
            context.SaveChanges();
        }

        /// <summary>
        /// Открытие вкладки магазина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            Shop shop = new Shop();
            shop.Show();
            this.Close();
        }

        /// <summary>
        /// Открытие вкладки аккаунта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountB_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();
        }

        /// <summary>
        /// Открытие вкладки корзины
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
        /// Сворачивание
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Закрытие приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
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

        /// <summary>
        /// Выбор игры из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameLB_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)
            {
                VisibleViewObjects();
            }
        }

        internal void VisibleViewObjects()
        {
            NameGame.Visibility = Visibility.Visible;
            DateLast.Visibility = Visibility.Visible;
            Develop.Visibility = Visibility.Visible;
            GoGame.Visibility = Visibility.Visible;
            LastUpd.Visibility = Visibility.Visible;
            News.Visibility = Visibility.Visible;
            TxtNews.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Вывод названия игры в меню игры из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string gameTxt = GameLB.SelectedItem.ToString();
            NameGame.Text = gameTxt;
            var reqGameID = context.logsGames.Where(x => x.NameGame == gameTxt).Select(x => x.GameID);
            var dateGameLast = from lg in context.logsGames
                               where lg.GameID == reqGameID.FirstOrDefault()
                               orderby lg.id descending
                               select lg.Date;
            DateLast.Text = dateGameLast.FirstOrDefault();

            var reqDev = context.games.Where(x => x.GameName == gameTxt).Single().idDeveloper;
            var nameDev = context.developers.Where(x => x.id == reqDev).Single().userName;
            Develop.Text = $"Разработчик: {nameDev}";
        }
    }
}
