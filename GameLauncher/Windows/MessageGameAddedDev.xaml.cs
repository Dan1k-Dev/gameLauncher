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

namespace GameLauncher.Windows
{
    /// <summary>
    /// Логика взаимодействия для MessageGameAddedDev.xaml
    /// </summary>
    public partial class MessageGameAddedDev : Window
    {
        LauncherDbContext context = new LauncherDbContext();
        public MessageGameAddedDev()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Если игру выпускает уеж сущесмтвующий разработчик
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var userN = from u in context.logs
                        orderby u.idLog descending
                        select u.userName;
            string name = userN.FirstOrDefault();

            var reqGanre = context.ganres.Where(x => x.NameGanre == ganreG.Content.ToString()).Single().idGanre;
            var reqDev = context.developers.Where(x => x.userName == name).FirstOrDefault().userID;

            var req = new Game()
            {
                GameName = gameG.Content.ToString(),
                Price = decimal.Parse(priceG.Content.ToString()),
                GameGanreID = reqGanre,
                Ganreee = (string)ganreG.Content,
                idDeveloper = reqDev,
            };
            context.games.Add(req);
            context.SaveChanges();
            this.Close();
        }
    }
}
