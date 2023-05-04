using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
using GameLauncher.Database;
using GameLauncher.Pages;

namespace GameLauncher.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditProfile.xaml
    /// </summary>
    public partial class EditProfile : Window
    {
        LauncherDbContext context = new LauncherDbContext();
        public EditProfile()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Account account = new Account();
            account.Show();
        }

        /// <summary>
        /// Принятие изменений
        /// Сохраняем новые данные 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Okay_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            MessageProfileEdited message = new MessageProfileEdited();

            if (Email.Text != "" && Nickname.Text != "" && Password.Text != "") //Проверка на пустоту
            {
                //Проверка на корректность почты
                if (Email.Text.Contains('@') && Email.Text.Contains(".com") || Email.Text.Contains('@') && Email.Text.Contains(".ru"))
                {
                    string userNick = account.Nickname.Text;

                    int userId = context.users.Where(x => x.UserName.Contains(userNick)).Single().idUser;
                    var userRow = context.users.Where(t => t.idUser == userId).FirstOrDefault();

                    var userName = context.users.Where(t => t.idUser == userId).FirstOrDefault().UserName;
                    var userPassw = context.users.Where(p => p.idUser == userId).FirstOrDefault().Password;

                    var devRow = context.developers.Where(d => d.userName == userName).FirstOrDefault();
                    if (devRow != null)
                    {
                        devRow.userName = Nickname.Text;
                        
                        userRow.Email = Email.Text;
                        userRow.UserName = Nickname.Text;
                        userRow.Password = Password.Text;
                        context.SaveChanges(); //Сохраняем данные

                        editLog();
                        account.Nickname.Text = Nickname.Text; //Меняем данные во вкладке
                        account.Email.Text = Email.Text;
                    }
                    else {
                        userRow.Email = Email.Text; 
                        userRow.UserName = Nickname.Text;
                        userRow.Password = Password.Text;
                        context.SaveChanges(); //Сохраняем данные

                        editLog();
                        account.Nickname.Text = Nickname.Text; //Меняем данные во вкладке
                        account.Email.Text = Email.Text;
                    }

                    account.Close();
                    message.Show();
                }
                else
                {
                    MessageEmailIncorrect emailIncorrect = new MessageEmailIncorrect(); //Сообщение некорректной почты
                    emailIncorrect.Show();
                }
            }
            else
            {
                MessageNoneData noneData = new MessageNoneData(); //Сообщение пустоты вводимых данных
                noneData.Show();
            }
        }

        /// <summary>
        /// Меняем ник не только в таблице Users, но и в логах
        /// </summary>
        internal void editLog()
        {
            DateTime date = DateTime.Now;
            string formatedDate = date.ToString("dd/M/yyyy");

            var userId = context.users.Where(x => x.UserName == Nickname.Text).Single().idUser;
            var reqLog = new Logs()
            {
                UserId = userId,
                Date = formatedDate,
                userName = Nickname.Text,
            };
            context.logs.Add(reqLog);
            context.SaveChanges();
        }

        private void Nickname_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Nickname.Text = "";
        }

        private void Email_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Email.Text = "";
        }

        private void Password_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Password.Text = "";
        }
    }
}
