using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GameLauncher.Pages;
using GameLauncher.Database;
using GameLauncher.Windows;
using System.Security.Principal;

namespace GameLauncher.Windows
{
    /// <summary>
    /// Логика взаимодействия для BalanceReplenishment.xaml
    /// </summary>
    public partial class BalanceReplenishment : Window
    {
        LauncherDbContext context = new LauncherDbContext();
        public BalanceReplenishment()
        {
            InitializeComponent();
        }

        private void Money_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Money.Text = "";
        }

        private void Okay_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            if (Money.Text != "")
            {
                if (decimal.TryParse(Money.Text, out decimal sum))
                {
                    BalanceSuccess balanceSuccess = new BalanceSuccess();

                    string userNick = account.Nickname.Text;

                    int userId = context.users.Where(x => x.UserName.Contains(userNick)).Single().idUser;
                    var userRow = context.users.Where(t => t.idUser == userId).FirstOrDefault();

                    userRow.Balance += decimal.Parse(Money.Text);
                    context.SaveChanges();

                    account.balance.Text += userRow.Balance;
                    editLog();
                    balanceSuccess.Show();
                }
                else
                {
                    MessageConverValue converValue = new MessageConverValue();
                    converValue.Show();
                }
            }
            else
            {
                MessageNoneData message = new MessageNoneData();
                message.Show();
            }
        }

        /// <summary>
        /// Логи при пополнении
        /// </summary>
        internal void editLog()
        {
            var reqUID = from u in context.logs
                         orderby u.idLog descending
                         select u.UserId;
            var reqCurUID = reqUID.FirstOrDefault();
            string date = DateTime.Now.ToString("dd/M/yyyy");

            var req = new LogsBalance()
            {
                UserID = reqCurUID,
                DateE = date,
                Status = "Пополнение",
                Summ = decimal.Parse(Money.Text),
            };
            context.logsBalances.Add(req);
            context.SaveChanges();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();
        }
    }
}
