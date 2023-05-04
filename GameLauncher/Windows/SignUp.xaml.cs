using GameLauncher.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace GameLauncher.Windows
{
    /// <summary>
    /// Логика взаимодействия для SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        LauncherDbContext context = new LauncherDbContext();
        public SignUp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Перетаскивание окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        /// <summary>
        /// Закрытие окна и переход на авторизацию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window.GetWindow(this).Close();
            MainWindow signIn = new MainWindow();
            signIn.Show();
        }

        /// <summary>
        /// Сворачивание окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeApp_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Отмена, возврат на авторизацию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow signIn = new MainWindow();
            signIn.Show();
            this.Close();
        }

        /// <summary>
        /// Сохранение созданного аккаунта
        /// Создание нового аккаунта в системе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAcc_Click(object sender, RoutedEventArgs e)
        {
            //Проверка на пустоту полей
            if (Nick.Text != "" && Passw.Password != "" && Email.Text != "")
            {
                //Проверка почты на корректность
                if (Email.Text.Contains('@') && Email.Text.Contains(".com") || Email.Text.Contains('@') && Email.Text.Contains(".ru"))
                {
                    var saveAcc = new User() //Сохраняем и создаем аккаунт
                    {
                        UserName = Nick.Text,
                        Password = Passw.Password,
                        Email = Email.Text,
                        Balance = 0,
                    };
                    context.users.Add(saveAcc);
                    context.SaveChanges();
                    PresentGameAdd();

                    MessageGamePresent gamePresent = new MessageGamePresent(); //Подарок от разработчиков лаунчера - игра
                    gamePresent.Show();
                    SignUpGreatSave greatSave = new SignUpGreatSave();
                    greatSave.Show();
                    this.Close();
                }
                //Вывод ошибок при неверно введенных (запрашиваемых) данных
                else
                {
                    emailIncorrect.Visibility = Visibility.Visible;
                }
            }
            else
            {
                emailIncorrect.Visibility = Visibility.Collapsed;
            }
            if (Nick.Text == "" && Passw.Password == "" && Email.Text == "") {
                SignUpErrorMessage signUp = new SignUpErrorMessage();
                signUp.Show();
            }
        }

        /// <summary>
        /// Выдача игры пользователю
        /// </summary>
        internal void PresentGameAdd()
        {
            var us = from c in context.users
                     orderby c.idUser descending
                     select c.idUser;
            var usID = us.FirstOrDefault();
            var req = new UserGames()
            {
                GameID = 1,
                UserID = usID
            };
            context.userGames.Add(req);
            context.SaveChanges();
        }

        private void Email_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Email.Text == "Введите ваш адрес почты") { Email.Text = ""; }
            emailIncorrect.Visibility = Visibility.Hidden;
        }

        private void Nick_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Nick.Text == "Создайте свой никнейм")
                Nick.Text = "";
        }

        private void Passw_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Passw.Password == "Password")
                Passw.Password = "";
        }
    }
}
