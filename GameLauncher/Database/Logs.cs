using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Database
{
    /// <summary>
    /// Логи для пользователей
    /// </summary>
    public class Logs
    {
        [Key]
        public int idLog { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string userName { get; set; }
        public string Date { get; set; }
    }
}
