using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using Excel = Microsoft.Office.Interop.Excel;
using GameLauncher.Pages;
using GameLauncher.Database;
using System.Windows.Markup;

namespace GameLauncher.Pages
{
    /// <summary>
    /// Логика взаимодействия для RepForBalance.xaml
    /// </summary>
    public partial class RepForBalance : Window
    {
        LauncherDbContext context = new LauncherDbContext();
        public RepForBalance()
        {
            InitializeComponent();

            var reqUser = from u in context.logs
                          orderby u.idLog descending
                          select u.UserId;
            var reqUID = reqUser.FirstOrDefault();

            var query = context.logsBalances.Where(x => x.UserID == reqUID).Select(x => new
            {
                x.DateE,
                x.Status,
                x.Summ
            }).ToList();
            DgInfoBalance.ItemsSource = query;
        }

        private void CloseLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();
        }

        private void MinimizeLauncher_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Создание отчета в Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddExcel_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.SheetsInNewWorkbook = 1;
            Excel.Workbook workBook = excelApp.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            workSheet.Name = "История операций";
            workSheet.Cells[1, 1] = ""; 
            workSheet.Range[workSheet.Cells[1, 1], workSheet.Cells[1, DgInfoBalance.Columns.Count]].Merge();

            for (int i = 1; i <= DgInfoBalance.Columns.Count; i++)
                workSheet.Cells[3, i] = DgInfoBalance.Columns[i - 1].Header;

            List<dynamic> itemsSource = new List<dynamic>();//Берем данные из datagrid
            foreach (var item in DgInfoBalance.Items)
            {
                itemsSource.Add(item);
            }

            List<string> headers = new List<string>();
            foreach (DataGridTextColumn c in DgInfoBalance.Columns)
            {
                headers.Add((c.Binding as Binding).Path.Path);
            }

            for (int i = 0; i < DgInfoBalance.Items.Count; i++)
            {
                for (int j = 0; j < headers.Count; j++)
                {
                    string cellContent = " " + itemsSource[i].GetType().GetProperty(headers[j]).GetValue(itemsSource[i], null).ToString();
                    workSheet.Cells[i + 4, j + 1] = cellContent;
                }
            }

            workSheet.Range[workSheet.Columns[1], workSheet.Columns[DgInfoBalance.Columns.Count]].AutoFit();
        
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
            var reqUser = from u in context.logs
                          orderby u.idLog descending
                          select u.UserId;
            var reqUID = reqUser.FirstOrDefault();

            if (SortBy.Text == "Списание")
            {
                var reqS = context.logsBalances.Where(x => x.Status == "Списание").Where(x => x.UserID == reqUID).Select(x => new
                {
                    x.DateE,
                    x.Status,
                    x.Summ
                }).ToList();

                DgInfoBalance.ItemsSource = reqS;
            }
            if (SortBy.Text == "Пополнение")
            {
                var reqS = context.logsBalances.Where(x => x.Status == "Пополнение").Where(x => x.UserID == reqUID).Select(x => new
                {
                    x.DateE,
                    x.Status,
                    x.Summ
                }).ToList();

                DgInfoBalance.ItemsSource = reqS;
            }
            if (SortBy.Text == "Все")
            {
                var req = from u in context.logs
                          orderby u.idLog descending
                          select u.UserId;
                var reqU = reqUser.FirstOrDefault();

                var query = context.logsBalances.Where(x => x.UserID == reqUID).Select(x => new
                {
                    x.DateE,
                    x.Status,
                    x.Summ
                }).ToList();
                DgInfoBalance.ItemsSource = query;
            }
        }
    }
}
