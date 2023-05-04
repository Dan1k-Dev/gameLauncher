using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using GameLauncher.Database;
using GameLauncher.Windows;
using Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace GameLauncher.Pages
{
    /// <summary>
    /// Логика взаимодействия для DevelopGame.xaml
    /// </summary>
    public partial class DevelopGame : System.Windows.Window
    {
        LauncherDbContext context = new LauncherDbContext();
        public DevelopGame()
        {
            InitializeComponent();

            var reqGanreCb = context.ganres.Select(x => x.NameGanre).ToList(); //Категории игр
            foreach (var ganre in reqGanreCb)
            {
                GanreCB.Items.Add(ganre);
            }
        }

        private void GameN_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            GameN.Text = "";
        }

        /// <summary>
        /// Добавление игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkGo_Click(object sender, RoutedEventArgs e)
        {
            Dev(); //Добавление игры
        }

        /// <summary>
        /// Добавление игры
        /// </summary>
        internal void Dev()
        {
            var userN = from u in context.logs
                        orderby u.idLog descending
                        select u.userName;
            string name = userN.FirstOrDefault(); //Получаем имя пользователя

            var userDev = from u in context.developers //Получаем имя разработчика
                          select u.userName;

            if (userDev.Contains(name)) //Если игру выкладывает разработчик, открываем сообщение для разработчика
            {
                if (GameN.Text != "" && PriceGame.Text != "")
                {
                    if (decimal.TryParse(PriceGame.Text, out decimal price))
                    {
                        if (GanreCB.Text != "")
                        {
                            MessageGameAddedDev gameAddedDev = new MessageGameAddedDev(); //Сообщение для разработчика
                            gameAddedDev.gameG.Content = GameN.Text;
                            gameAddedDev.ganreG.Content = GanreCB.Text;
                            gameAddedDev.priceG.Content = price;
                            gameAddedDev.Show();
                        }
                        else
                        {
                            MessageNoneData noneData = new MessageNoneData(); //Сообщение об ошибке данных
                            noneData.Show();

                        }
                    }
                    else
                    {
                        MessageConverValue converValue = new MessageConverValue(); //Сообщение об ошибке денежного ввода
                        converValue.Show();
                    }
                }
            }
            else //Если игру выкладывает не разработчик, присваеваем ему роль - разработчик
            {
                if (decimal.TryParse(PriceGame.Text, out decimal price))
                {
                    if (GanreCB.Text != "")
                    {
                        MessageGameAdded gameAdded = new MessageGameAdded(); //Сообщение для будущего разработчика
                        gameAdded.gameName.Content = GameN.Text;
                        gameAdded.priceT.Content = price;
                        gameAdded.ganreN.Content = GanreCB.Text;
                        gameAdded.Show();
                    }
                    else
                    {
                        MessageNoneData noneData = new MessageNoneData(); //Ошибка данных
                        noneData.Show();
                    }
                }
                else
                {
                    MessageConverValue converValue = new MessageConverValue(); // Ошибка денежного формата
                    converValue.Show();
                }
            }
        }

        /// <summary>
        /// Очистка поля ввода с ценой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PriceGame_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            PriceGame.Text = "";
        }

        /// <summary>
        /// Вернуться обратно на предыдущее окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
