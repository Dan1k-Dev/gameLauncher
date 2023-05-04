using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Database
{
    /// <summary>
    /// Библиотека игр пользователя
    /// </summary>
    public class UserGames
    {
        [Key]
        public int id { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int GameID { get; set; }
        public virtual Game Game { get; set; }
    }
}
