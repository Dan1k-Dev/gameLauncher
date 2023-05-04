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

namespace GameLauncher.Windows
{
    /// <summary>
    /// Логика взаимодействия для BalanceSuccess.xaml
    /// </summary>
    public partial class BalanceSuccess : Window
    {
        public BalanceSuccess()
        {
            InitializeComponent();
        }

        private void Close_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
