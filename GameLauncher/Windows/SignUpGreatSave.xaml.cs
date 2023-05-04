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

namespace GameLauncher.Windows
{
    /// <summary>
    /// Логика взаимодействия для SignUpGreatSave.xaml
    /// </summary>
    public partial class SignUpGreatSave : Window
    {
        public SignUpGreatSave()
        {
            InitializeComponent();
        }

        private void Close_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow signIn = new MainWindow();
            signIn.Show();
            this.Close();
        }
    }
}
