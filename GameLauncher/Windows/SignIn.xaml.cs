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
using System.Windows.Navigation;
using System.Windows.Shapes;
using GameLauncher.Windows;
using GameLauncher.Pages;
using GameLauncher.Database;

namespace GameLauncher
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LauncherDbContext context = new LauncherDbContext();
        SignUp signUp = new SignUp();
        Shop shop = new Shop();
        Develop develop = new Develop();

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверка полей ввода на пустоту и авторизация в лаунчере
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            var userLogin = txtEmail.Text;
            var userPassw = txtPassword.Password;

            var dataLogin = context.users.Where(l => l.UserName == userLogin).FirstOrDefault();
            var dataPassw = context.users.Where(p => p.Password == userPassw).FirstOrDefault();

            if (dataLogin != null && dataPassw != null)
            {
                if (txtEmail.Text == dataLogin.UserName && txtPassword.Password == dataPassw.Password)
                {
                    AddLog();
                    shop.Show();
                    this.Close();
                }
                else incorrectInfo.Visibility = Visibility.Visible;
            }
            else incorrectInfo.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Получаем последний заход в лаунчер от пользователя
        /// </summary>
        /// <param name="CurDate"></param>
        internal void AddLog()
        {
            DateTime date = DateTime.Now;
            string formatedDate = date.ToString("dd/M/yyyy");

            var userId = context.users.Where(p => p.UserName.Contains(txtEmail.Text)).Single().idUser;

            var reqLog = new Logs()
            {
                UserId = userId,
                Date = formatedDate,
                userName = txtEmail.Text,
            };
            context.logs.Add(reqLog);
            context.SaveChanges();
        }

        /// <summary>
        /// Передвижение окна по экрану
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        /// <summary>
        /// Закрытие приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseApp_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Очищение строки ввода email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Text = "";
            incorrectInfo.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Очищение строки ввода пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Password = "";
            incorrectInfo.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Google диск с проектом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void googleSite_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://drive.google.com/drive/folders/1Xlu3KyrBNoukPdZc-NHovWlqSJkOF99i?usp=share_link");
        }

        /// <summary>
        /// Гитхаб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GitHubSite_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/Dan1k-Dev");
        }

        /// <summary>
        /// Страница ВК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vkSite_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/frol_s");
        }

        /// <summary>
        /// Вкладка регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            signUp.Show();
            this.Close();
        }

        /// <summary>
        /// Свернуть лаунчер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minimize_MouseUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
