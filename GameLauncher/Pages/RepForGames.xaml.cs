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
using GameLauncher.Database;
using GameLauncher.Pages;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.IO;

namespace GameLauncher.Pages
{
    /// <summary>
    /// Логика взаимодействия для RepForGames.xaml
    /// </summary>
    public partial class RepForGames : Window
    {
        LauncherDbContext context = new LauncherDbContext();
        public RepForGames()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Свернуть лаунчер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Закрыть лаунчер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Develop develop = new Develop();
            develop.Show();
            this.Close();
        }

        /// <summary>
        /// Создание отчета в эксель
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddExcel_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.SheetsInNewWorkbook = 1;
            Excel.Workbook workBook = excelApp.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            workSheet.Name = "Отчет";
            workSheet.Cells[1, 1] = "";
            workSheet.Range[workSheet.Cells[1, 1], workSheet.Cells[1, DgInfoGames.Columns.Count]].Merge();

            for (int i = 1; i <= DgInfoGames.Columns.Count; i++)
                workSheet.Cells[3, i] = DgInfoGames.Columns[i - 1].Header;

            List<dynamic> itemsSource = new List<dynamic>();//Берем данные из datagrid
            foreach (var item in DgInfoGames.Items)
            {
                itemsSource.Add(item);
            }

            List<string> headers = new List<string>();
            foreach (DataGridTextColumn c in DgInfoGames.Columns)
            {
                headers.Add((c.Binding as Binding).Path.Path);
            }

            for (int i = 0; i < DgInfoGames.Items.Count; i++)
            {
                for (int j = 0; j < headers.Count; j++)
                {
                    string cellContent = " " + itemsSource[i].GetType().GetProperty(headers[j]).GetValue(itemsSource[i], null).ToString();
                    workSheet.Cells[i + 4, j + 1] = cellContent;
                }
            }

            workSheet.Range[workSheet.Columns[1], workSheet.Columns[DgInfoGames.Columns.Count]].AutoFit();

            excelApp.Visible = true;
            excelApp.DisplayAlerts = false;
        }

        /// <summary>
        /// Выборка отчетов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string gameTxt = SortBy.SelectedItem.ToString();
        }

        /// <summary>
        /// Сортировка данных для отчетов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            var reqDev = from u in context.logs
                         orderby u.idLog descending
                         select u.UserId;
            var reqCurDev = reqDev.FirstOrDefault();

            if (SortBy.Text == "Все выпущенные игры")
            { 
                var reqAllGames = context.games.Where(x => x.idDeveloper == reqCurDev).Select(x => new
                {
                    game = x.GameName,
                    ganre = x.Ganreee,
                    price = x.Price,
                    countBuyy = x.countBuy
                }).ToList();
                DgInfoGames.ItemsSource = reqAllGames;
            }
            if (SortBy.Text == "Все проданные игры")
            {
                var reqAllGames = context.games.Where(x => x.idDeveloper == reqCurDev).Where(x => x.countBuy >= 1).Select(x => new
                {
                    game = x.GameName,
                    ganre = x.Ganreee,
                    price = x.Price,
                    countBuyy = x.countBuy
                }).ToList();
                DgInfoGames.ItemsSource = reqAllGames;
            }
            if (SortBy.Text == "Топ 1 продаж")
            {
                var reqGameTopOne = context.games.Where(x => x.idDeveloper == reqCurDev).Select(x => new
                {
                    x.GameName,
                    x.Ganre,
                    x.Price,
                    x.countBuy
                }).ToList();
                DgInfoGames.ItemsSource = reqGameTopOne;
            }
            if (SortBy.Text == "Топ 3 продаж")
            {
                 
            }
        }
    }
}
