using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Database
{
    /// <summary>
    /// Пользователи
    /// </summary>
    public class User
    {
        [Key]
        public int idUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public decimal? Balance { get; set; }
    }
}
