using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Database
{
    public class LogsBalance
    {
        [Key]
        public int id { get; set; }
        public string DateE { get; set; }
        public decimal Summ { get; set; }
        public string Status { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
