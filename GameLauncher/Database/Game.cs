using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Database
{
    /// <summary>
    /// Игры (в магазине)
    /// </summary>
    public class Game
    {
        [Key]
        public int idGame { get; set; }
        public string GameName { get; set; }
        public int idDeveloper { get; set; }
        public virtual Developer DeveloperID { get; set; }
        public int GameGanreID { get; set; }
        public string Ganreee { get; set; }
        public virtual Ganre Ganre { get; set; }
        public decimal Price { get; set; }
        public int countBuy { get; set; }
    }
}
