using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GameLauncher.Database
{
    public class LauncherDbContext : DbContext
    {
        public LauncherDbContext() : base("ConnectionString")
        {

        }
        public DbSet<CartGames> carts { get; set; } //Корзина
        public DbSet<Game> games { get; set; } //Игры
        public DbSet<Ganre> ganres { get; set; } //Жанры
        public DbSet<Logs> logs { get; set; } //Логи (отслеживание действий пользователя)
        public DbSet<User> users { get; set; } //Пользователи
        public DbSet<LogsGames> logsGames { get; set; } //Отслеживание покупок игр в магазине
        public DbSet<Developer> developers { get; set; } //Разработчики
        public DbSet<UserGames> userGames { get; set; } //Игры пользователей
        public DbSet<LogsBalance> logsBalances { get; set; }
    }
}
