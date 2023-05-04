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

namespace GameLauncher.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditGame.xaml
    /// </summary>
    public partial class EditGame : Window
    {
        LauncherDbContext context = new LauncherDbContext();
        public EditGame()   
        {
            InitializeComponent();

            var reqUID = from u in context.logs
                         orderby u.idLog descending
                         select u.UserId;
            var reqCurUID = reqUID.FirstOrDefault();

            var reqGanreCb = context.ganres.Select(x => x.NameGanre).ToList(); //Категории игр
            foreach (var ganre in reqGanreCb)
            {
                GanreCB.Items.Add(ganre);
            }

            var reqDev = context.developers.Where(x => x.userID == reqCurUID).Single().id;
            var reqGame = context.games.Where(x => x.idDeveloper == reqDev).Select(x => x.GameName).ToList(); //Игры
            foreach (var game in reqGame)
            {
                GameN.Items.Add(game);
            }
        }
            
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Редактирование игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkGo_Click(object sender, RoutedEventArgs e)
        {
            if (GameN.Text != "" && GanreCB.Text != "" && PriceGame.Text != "")
            {
                if (decimal.TryParse(PriceGame.Text, out decimal price))
                {
                    string gameName = GameN.Text;
                    int gameID = context.games.Where(x => x.GameName == gameName).Single().idGame;
                    var gameRow = context.games.Where(x => x.idGame == gameID).FirstOrDefault(); //id игры

                    var ganreID = context.ganres.Where(x => x.NameGanre == GanreCB.Text).Single().idGanre; //id жанр

                    var reqUID = from u in context.logs
                                 orderby u.idLog descending
                                 select u.UserId;
                    var reqCurUID = reqUID.FirstOrDefault(); //id пользователь

                    gameRow.GameName = GameN.Text;
                    gameRow.GameGanreID = ganreID;
                    gameRow.Price = decimal.Parse(PriceGame.Text);
                    gameRow.idDeveloper = reqCurUID;
                    context.SaveChanges();

                    MessageGameEdit gameEdit = new MessageGameEdit();
                    gameEdit.Show();
                }
                else
                {
                    MessageConverValue converValue = new MessageConverValue();
                    converValue.Show();
                }
            }
            else
            {
                MessageNoneData messageNoneData = new MessageNoneData();
                messageNoneData.Show();
            }
        }

        private void PriceGame_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            PriceGame.Text = "";
        }

        private void GameN_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string gameTxt = GameN.SelectedItem.ToString();

            var gamePrice = context.games.Where(x => x.GameName == gameTxt).Single().Price;
            PriceGame.Text = $"Нынешняя цена: {gamePrice}";
        }
    }
}
