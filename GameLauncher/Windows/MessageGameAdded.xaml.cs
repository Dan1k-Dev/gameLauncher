using GameLauncher.Database;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace GameLauncher.Windows
{
    /// <summary>
    /// Логика взаимодействия для MessageGameAdded.xaml
    /// </summary>
    public partial class MessageGameAdded : System.Windows.Window
    {
        LauncherDbContext context = new LauncherDbContext();
        public MessageGameAdded()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Закрываем окно и добавляем данные игры и нового разработчика 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();

            var userN = from u in context.logs
                        orderby u.idLog descending
                        select u.userName;
            string name = userN.FirstOrDefault(); //Получаем имя пользователя в системе

            var reqGanre = context.ganres.Where(x => x.NameGanre == ganreN.Content.ToString()).Single().idGanre; //Получаем id значения таблицы
                                                                                                                //жанры

            var UID = context.logs.Where(x => x.userName == name).FirstOrDefault().UserId; //Получаем UID
            var req = new Developer()
            {
                userID = UID,
                userName = name
            };
            context.developers.Add(req);
            context.SaveChanges(); //Добавляем в таблицу "разработчики" нового разработчика

            var reqDev = context.developers.Where(x => x.userName == name).FirstOrDefault().userID;
            var reqG = new Game()
            {
                GameName = gameName.Content.ToString(),
                Price = decimal.Parse(priceT.Content.ToString()),
                GameGanreID = reqGanre,
                idDeveloper = reqDev,
            };
            context.games.Add(reqG);
            context.SaveChanges(); //Добавляем новую игру
        }
    }
}
