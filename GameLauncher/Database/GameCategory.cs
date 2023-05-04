using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Database
{
    /// <summary>
    /// Категории игр
    /// </summary>
    public class GameCategory
    {
        [Key]
        public int idCategory { get; set; }
        public string NameCategory { get; set; }
    }
}
