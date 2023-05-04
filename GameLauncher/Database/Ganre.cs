using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Database
{
    /// <summary>
    /// Жанры (категории) игр
    /// </summary>
    public class Ganre
    {
        [Key]
        public int idGanre { get; set; }
        public string NameGanre { get; set; }
    }
}
