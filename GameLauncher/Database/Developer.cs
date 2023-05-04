using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Database
{
    /// <summary>
    /// Разработчики
    /// </summary>
    public class Developer
    {
        [Key]
        public int id { get; set; }
        public int userID { get; set; }
        public virtual User User { get; set; }
        public string userName { get; set; }
    }
}
