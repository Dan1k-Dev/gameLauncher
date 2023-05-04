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
using GameLauncher.Database;
using GameLauncher.Windows;
using Word = Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace GameLauncher.Pages
{
    /// <summary>
    /// Логика взаимодействия для Shop.xaml
    /// </summary>
    public partial class Shop : System.Windows.Window
    {
        LauncherDbContext context = new LauncherDbContext();
        public Shop()
        {
            InitializeComponent();

            AllGames(); //Выводим все игры

            var reqGanreCb = context.ganres.Select(x => x.NameGanre).ToList(); //Категории игр
            foreach (var ganre in reqGanreCb)
            {
                CategoryCB.Items.Add(ganre);
            }
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
        /// Вкладка аккаунт
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
        /// Свернуть лаунчер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Window.GetWindow(this).WindowState = WindowState.Minimized;
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
        /// Сортируем игры по жанру
        /// </summary>
        internal void Sorted()
        {
            if (CategoryCB.Text == "Все игры")
            {
                AllGames(); // Выводим все игры
            }
            else
            {
                var reqGanreID = context.ganres.Where(x => x.NameGanre == CategoryCB.Text).Single().idGanre;
                var reqGame = from g in context.games
                              where g.GameGanreID == reqGanreID
                              where g.GameName != "Dotz"
                              select g.GameName;
                string[] games = reqGame.ToArray();

                foreach (var game in games)
                {
                    var reqIdGanre = context.games.Where(x => x.GameName == game).FirstOrDefault().GameGanreID; //Id жанр
                    var reqPrice = context.games.Where(x => x.GameName == game).Single().Price; //Цена
                    var reqGanre = context.ganres.Where(x => x.idGanre == reqIdGanre).Single().NameGanre; //Наименование жанра
                    var reqDevID = context.games.Where(x => x.GameName == game).Single().idDeveloper; //id разработчика
                    var reqDevName = context.developers.Where(x => x.id == reqDevID).Single().userName; //разработчик

                    GameShopLB.Items.Add(string.Format("{0} | Жанр: {1} | Разработчик: {2} \n Цена: {3} ₽", game, reqGanre, reqDevName, reqPrice));
                }
            }
        }

        /// <summary>
        /// Вывод всех игр
        /// </summary>
        internal void AllGames()
        {
            GameShopLB.Items.Clear();
            var reqGame = from g in context.games
                          where g.GameName != "Dotz"
                          select g.GameName;
            string[] games = reqGame.ToArray();
            for (int i = games.Length - 1; i >= 1; i--)
            {
                Random rand = new Random();
                int j = rand.Next(i + 1);
                string temp = games[j];
                games[j] = games[i];
                games[i] = temp; //Перемешиваем элементы пузырьковой сортировкой, используя рандомное значения индекса

                var reqIdGanre = context.games.Where(x => x.GameName == temp).FirstOrDefault().GameGanreID; //Id жанр
                var reqPrice = context.games.Where(x => x.GameName == temp).Single().Price; //Цена
                var reqGanre = context.ganres.Where(x => x.idGanre == reqIdGanre).Single().NameGanre; //Наименование жанра
                var reqDevID = context.games.Where(x => x.GameName == temp).Single().idDeveloper; //id разработчика
                var reqDevName = context.developers.Where(x => x.id == reqDevID).Single().userName; //разработчик

                GameShopLB.Items.Add(string.Format("{0} | Жанр: {1} | Разработчик: {2} \n Цена: {3} ₽", temp, reqGanre, reqDevName, reqPrice));
            }
        }

        /// <summary>
        /// Добавление игр в корзину через таблицу Cart
        /// Вкладка "Корзина"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InCart_Click(object sender, RoutedEventArgs e)
        {
            if (GameShopLB.SelectedIndex > -1)
            {
                string txtGame = GameShopLB.SelectedItem.ToString(); //Получаем название игры
                string curGame = txtGame.Substring(0, txtGame.IndexOf('|'));
                int gameId = context.games.Where(x => x.GameName == curGame).Single().idGame;
                var idCartGame = context.carts.Select(x => x.GameID).ToList();

                if (idCartGame.Contains(gameId))
                {
                    GameCurInCart gameCurIn = new GameCurInCart();
                    gameCurIn.Show();
                }
                else
                {
                    var reqIdGanre = context.games.Where(x => x.GameName == curGame).Single().GameGanreID; //Id жанр
                    var ganre = context.ganres.Where(x => x.idGanre == reqIdGanre).Single().NameGanre; //Наименование жанра

                    var reqNameUser = from u in context.logs
                                      orderby u.idLog descending
                                      select u.UserId;
                    int idUser = reqNameUser.FirstOrDefault(); //Получаем id пользователя, который добавляет себе игру в корзину

                    var reqPriceGame = context.games.Where(x => x.GameName == curGame).Single().Price; //Получаем цену игры
                    var reqIdGame = context.games.Where(x => x.GameName == curGame).Single().idGame; //id добавляемой игры

                    var reqCart = new CartGames()   
                    {
                        GameID = reqIdGame,
                        Ganre = ganre,
                        UserId = idUser,
                        Price = reqPriceGame
                    };
                    context.carts.Add(reqCart);
                    GameAddedToCart addedToCart = new GameAddedToCart();
                    addedToCart.Show();
                    context.SaveChanges(); //Добавляем игры в корзину
                }
            }
        }

        /// <summary>
        /// Сортировка игр по жанрам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CategoryCB.Text = CategoryCB.SelectedItem.ToString();
            GameShopLB.Items.Clear();
            Sorted();
        }
    }
}
