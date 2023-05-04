using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Database
{
    /// <summary>
    /// Комментарии к играм
    /// </summary>
    public class CommentGame
    {
        [Key]
        public int id { get; set; }
        public string userName { get; set; }
        public string game { get; set; }
        public string dev { get; set; }
        public string comment { get; set; }
    }
}
