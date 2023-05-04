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
    /// Логика взаимодействия для SignUpErrorMessage.xaml
    /// </summary>
    public partial class SignUpErrorMessage : Window
    {
        public SignUpErrorMessage()
        {
            InitializeComponent();
        }

        private void Close_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
