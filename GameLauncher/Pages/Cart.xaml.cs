using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using GameLauncher.Database;
using GameLauncher.Windows;

namespace GameLauncher.Pages
{
    /// <summary>
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        LauncherDbContext context = new LauncherDbContext();
        public Cart()
        {
            InitializeComponent();

            var reqUs = from u in context.logs
                        orderby u.idLog descending
                        select u.UserId;
            var UID = reqUs.FirstOrDefault();

            var reqGame = context.carts.Where(x => x.UserId == UID).Select(x => x.GameID).ToList(); // вывод игр в listbox
            foreach (var game in reqGame)
            {
                var reqGameName = context.games.Where(x => x.idGame == game).Single().GameName; //Наименование игры
                var reqGanre = context.games.Where(x => x.idGame == game).Select(x => x.Ganre).FirstOrDefault(); //Жанр
                var reqPrice = context.games.Where(x => x.idGame == game).Select(x => x.Price).FirstOrDefault(); //Цена
                CartLb.Items.Add(string.Format("{0} | {1} | Цена: {2} ₽", reqGameName, reqGanre, reqPrice)); //Вывод
            }
        }

        /// <summary>
        /// Вкладка магазин
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
        /// Вкладка игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Games_Click(object sender, RoutedEventArgs e)
        {
            Games games = new Games();
            games.Show();
            this.Close();
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
        /// Покупка одной игры из корзины
        /// Производится добавление игры из корзины в билиотеку игр пользователя
        /// Составляется и выводится чек о покупке игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuyGame_Click(object sender, RoutedEventArgs e)
        {
            var reqUID = from l in context.logs //id юзера
                         orderby l.idLog descending
                         select l.UserId;
            int curUser = reqUID.FirstOrDefault();

            var reqBalanceUser = from u in context.users
                                 where u.idUser == curUser
                                 select u.Balance;
            var reqBalance = reqBalanceUser.FirstOrDefault(); //Баланс пользователя

            if (CartLb.SelectedItems != null)
            {
                var reqNameGame = CartLb.SelectedItem.ToString();
                var reqGame = reqNameGame.Substring(0, reqNameGame.IndexOf('|')); //Имя игры
                var reqGID = context.games.Where(x => x.GameName == reqGame).Single().idGame;

                var reqGameID = from g in context.carts
                                where g.GameID == reqGID
                                select g.GameID;
                var reqCurGame = reqGameID.FirstOrDefault(); //Получаем выбранную игру

                var req = context.userGames.Where(x => x.UserID == curUser).Select(x => x.GameID).ToList();

                decimal sumGame = context.games.Where(x => x.idGame == reqCurGame).Single().Price; //Считаем сумму игр(-ы)

                if (sumGame <= reqBalance) //Проверка баланса при покупке
                {
                    if (req.Contains(reqCurGame))
                    {
                        MessageGameInBibliory messageGameIn = new MessageGameInBibliory();
                        messageGameIn.Show();
                    }
                    else
                    {
                        var reqBuy = new UserGames()
                        {
                            GameID = reqCurGame,
                            UserID = curUser
                        };
                        context.userGames.Add(reqBuy); //Добавляем игру в библиотеку
                        context.SaveChanges();
                            
                        decimal price = context.games.Where(x => x.GameName == reqGame).Single().Price;
                        var userRow = context.users.Where(x => x.idUser == curUser).FirstOrDefault();

                        var gameRow = context.games.Where(x => x.idGame == reqCurGame).FirstOrDefault(); //Прибавляем кол-во покупок
                        gameRow.countBuy += 1;

                        userRow.Balance -= price; //Убавляем баланс при покупке платных игр

                        //реализовать убавление баланса при покупке не одной, а нескольких игр

                        var gameToRemove = context.carts.Where(x => x.UserId == curUser).SingleOrDefault(x => x.GameID == reqCurGame); //удаление из корзины
                        if (gameToRemove != null)
                        {
                            context.carts.Remove(gameToRemove);
                            context.SaveChanges();
                            CartLb.Items.RemoveAt(CartLb.SelectedIndex);
                        }

                        string date = DateTime.Now.ToString("dd/M/yyyy"); // Логи при списании по покупке игры
                        var reqLB = new LogsBalance()
                        {
                            UserID = curUser,
                            DateE = date,
                            Status = "Списание",
                            Summ = sumGame
                        };
                        context.logsBalances.Add(reqLB);
                        context.SaveChanges();

                        MessageGameExist gameExist = new MessageGameExist(); //Игра добавлена в библиотеку
                        gameExist.Show();
                    }
                }
                else
                {
                    BuyFail buyFail = new BuyFail(); //Покупка не совершилась, баланс меньше стоимости игр
                    buyFail.Show();
                }
            }
            else
            {
                MessageGameNone gameNone = new MessageGameNone();
                gameNone.Show();
            }
        }

        /// <summary>
        /// Удаление одной игры из корзины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteGame_Click(object sender, RoutedEventArgs e)
        {

            var reqUID = from l in context.logs //id юзера
                         orderby l.idLog descending
                         select l.UserId;
            int curUser = reqUID.FirstOrDefault();

            var reqNameGame = CartLb.SelectedItem.ToString();
            var reqGame = reqNameGame.Substring(0, reqNameGame.IndexOf('|')); //Имя игры
            var reqGID = context.games.Where(x => x.GameName == reqGame).Single().idGame;

            var reqGameID = from g in context.carts
                            where g.GameID == reqGID
                            select g.GameID;
            var reqCurGame = reqGameID.FirstOrDefault(); //Получаем выбранную игру

            var gameToRemove = context.carts.Where(x => x.UserId == curUser).SingleOrDefault(x => x.GameID == reqCurGame); //удаление из корзины
            if (gameToRemove != null)
            {
                context.carts.Remove(gameToRemove);
                context.SaveChanges();
                CartLb.Items.RemoveAt(CartLb.SelectedIndex);
            }
            else
            {
                NonGameSelect nonGame = new NonGameSelect(); //Ошибка - игра не выбрана
                nonGame.Show();
            }
        }

        /// <summary>
        /// Открыть 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DevelopB_Click(object sender, RoutedEventArgs e)
        {
            Develop develop = new Develop();
            develop.Show();
            this.Close();
        }
    }
}
