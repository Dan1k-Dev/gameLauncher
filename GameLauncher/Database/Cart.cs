using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Database
{
    /// <summary>
    /// Корзина
    /// </summary>
    public class Cart
    {
        [Key]
        public int idCart { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int GameID { get; set; }
        public virtual Game Game { get; set; }
        public int CategoryID { get; set; }
        public virtual GameCategory Category { get; set; }
        public int GanreID { get; set; }
        public virtual Ganre Ganre { get; set; }
    }
}
