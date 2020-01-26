using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MyFinances.Helpers;
using MyFinances.Models;

namespace MyFinances.View
{
    /// <summary>
    /// Логика взаимодействия для TabMenu.xaml
    /// </summary>
    public partial class TabMenu
    {
        private int _idUserForTabMenu;
        private Transaction _transactionForRemove;
        private Debt _debtForRemove;
        private Accumulation _accumulationForRemove;
        private User user;

        


        public TabMenu(int id)
        {
            InitializeComponent();

            _idUserForTabMenu = id;

            Activated += TabMenu_Activated;

        }

        private void TabMenu_Activated(object sender, EventArgs e)
        {
            user = new User();
            Accumulation accumulation = new Accumulation();

            // Getting User Id

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Id == _idUserForTabMenu);
                    accumulation = db.Accumulations.FirstOrDefault(a => a.UserId == _idUserForTabMenu);

                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // DataGrid Update

            Functions.UpdateDataGridsTabMenu(dataGridCosts, user);
            Functions.UpdateDataGridsTabMenu(dataGridIncomes, user);
            Functions.UpdateDataGridsTabMenu(dataGridDebts, user);
            Functions.UpdateDataGridsTabMenu(dataGridAccumulation, user);

        }

        // Autogeneration of the necessary columns for the withdrawal of income

        private void dataGridCosts_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headerName = e.Column.Header.ToString();

            switch (headerName)
            {
                case "Cost":
                    e.Column.Header = "Сумма";
                    break;
                case "DateTimeTransaction":
                    e.Column.Header = "Дата операции";
                    break;
                case "CategoryName":
                    e.Column.Header = "Категория";
                    break;
                case "CommentforCategory":
                    e.Column.Header = "Комментарий";
                    break;

                default:
                    e.Cancel = true;
                    break;
            }

        }

        // Auto generation of necessary columns for output

        private void dataGridIncomes_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headerName = e.Column.Header.ToString();

            switch (headerName)
            {
                case "Income":
                    e.Column.Header = "Сумма";
                    break;
                case "DateTimeTransaction":
                    e.Column.Header = "Дата операции";
                    break;
                case "CommentforCategory":
                    e.Column.Header = "Комментарий";
                    break;

                default:
                    e.Cancel = true;
                    break;
            }
        }

        // Autogeneration of the necessary columns for the withdrawal of debtors

        private void dataGridDebts_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headerName = e.Column.Header.ToString();

            switch (headerName)
            {
                case "DebtName":
                    e.Column.Header = "Имя должника";
                    break;
                case "SummofDebt":
                    e.Column.Header = "Сумма долга";
                    break;
                case "DateEndDate":
                    e.Column.Header = "Вернуть до...";
                    break;

                default:
                    e.Cancel = true;
                    break;
            }
        }

        // Autogeneration of necessary columns for withdrawal of accumulations

        private void dataGridAccumulation_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headerName = e.Column.Header.ToString();

            switch (headerName)
            {
                case "DateTimeAccumulation":
                    e.Column.Header = "Дата";
                    break;
                case "AccumulationName":
                    e.Column.Header = "Запланированная покупка";
                    break;
                case "SummofAccumulation":
                    e.Column.Header = "Стоимость";
                    break;
                case "Accumulated":
                    e.Column.Header = "Собрано";
                    break;

                default:
                    e.Cancel = true;
                    break;
            }
        }


        private void dataGridCosts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGridCosts.SelectedItem != null)
            {
                btnRemoveOperationCost.IsEnabled = true;
            }
            else
            {
                btnRemoveOperationCost.IsEnabled = false;
            }
        }

        private void dataGridIncomes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGridIncomes.SelectedItem != null)
            {
                btnRemoveOperationIncome.IsEnabled = true;
            }
            else
            {
                btnRemoveOperationIncome.IsEnabled = false;
            }
        }

        private void dataGridDebts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGridDebts.SelectedItem != null)
            {
                btnRemoveOperationDebt.IsEnabled = true;
            }
            else
            {
                btnRemoveOperationDebt.IsEnabled = false;
            }
        }

        private void dataGridAccumulation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGridAccumulation.SelectedItem != null)
            {
                btnRemoveAccumulation.IsEnabled = true;
            }
            else
            {
                btnRemoveAccumulation.IsEnabled = false;
            }
        }


        private void btnAddCosts_Click(object sender, RoutedEventArgs e)
        {
            AddCosts addCosts = new AddCosts(_idUserForTabMenu);
            addCosts.ShowDialog();
            addCosts.ShowInTaskbar = false;
        }

        private void btnRemoveOperationCost_Click(object sender, RoutedEventArgs e)
        {
            // Removing an operation from the Expenses list

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    TransactionsPlusCategory temp = dataGridCosts.SelectedItem as TransactionsPlusCategory;

                    _transactionForRemove = new Transaction();

                    foreach (var item in db.Transactions)
                    {


                        if (item.UserId == _idUserForTabMenu &&
                            item.DateTimeTransaction == temp.DateTimeTransaction &&
                            item.Cost == temp.Cost &&
                            item.CommentforCategory == temp.CommentforCategory)
                        {
                            _transactionForRemove = item;
                        }

                    }

                    db.Transactions.Remove(_transactionForRemove);
                    db.SaveChanges();

                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // DataGrid Update

            Functions.UpdateDataGridsTabMenu(dataGridCosts, user);
        }

        private void btnAddIncome_Click(object sender, RoutedEventArgs e)
        {
            AddIncomes addIncomes = new AddIncomes(_idUserForTabMenu);
            addIncomes.ShowDialog();
            addIncomes.ShowInTaskbar = false;
        }

        private void btnRemoveOperationIncome_Click(object sender, RoutedEventArgs e)
        {
            // Delete an operation from the Income list

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    Transaction temp = dataGridIncomes.SelectedItem as Transaction;

                    _transactionForRemove = new Transaction();

                    foreach (var item in db.Transactions)
                    {


                        if (item.UserId == _idUserForTabMenu &&
                            item.DateTimeTransaction == temp.DateTimeTransaction &&
                            item.Income == temp.Income &&
                            item.CommentforCategory == temp.CommentforCategory)
                        {
                            _transactionForRemove = item;
                        }

                    }

                    db.Transactions.Remove(_transactionForRemove);
                    db.SaveChanges();

                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            // DataGrid Update

            Functions.UpdateDataGridsTabMenu(dataGridIncomes, user);
        }


        private void btnAddDebts_Click(object sender, RoutedEventArgs e)
        {
            AddDebts addDebts = new AddDebts(_idUserForTabMenu);
            addDebts.ShowDialog();
            addDebts.ShowInTaskbar = false;
        }

        private void btnRemoveOperationDebt_Click(object sender, RoutedEventArgs e)
        {
            // Removing an operation from the Debts list

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    Debt temp = dataGridDebts.SelectedItem as Debt;

                    _debtForRemove = new Debt();

                    foreach (var item in db.Debts)
                    {


                        if (item.UserId == _idUserForTabMenu &&
                            item.DateEndDate == temp.DateEndDate &&
                            item.SummofDebt == temp.SummofDebt &&
                            item.DebtName == temp.DebtName)
                        {
                            _debtForRemove = item;
                        }

                    }

                    db.Debts.Remove(_debtForRemove);
                    db.SaveChanges();

                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // DataGrid Update

            Functions.UpdateDataGridsTabMenu(dataGridDebts, user);
        }


        private void btnAddAccumulation_Click(object sender, RoutedEventArgs e)
        {
            AddAccumulation addAccumulation = new AddAccumulation(_idUserForTabMenu);
            addAccumulation.ShowDialog();
            addAccumulation.ShowInTaskbar = false;
        }

        private void btnAddSumm_Click(object sender, RoutedEventArgs e)
        {
            AddSummForAccumulation addSummForAccumulation = new AddSummForAccumulation(_idUserForTabMenu);
            addSummForAccumulation.ShowDialog();
            addSummForAccumulation.ShowInTaskbar = false;
        }

        private void btnRemoveAccumulation_Click(object sender, RoutedEventArgs e)
        {
            // Removing an operation from the Accumulation list

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    Accumulation temp = dataGridAccumulation.SelectedItem as Accumulation;

                    _accumulationForRemove = new Accumulation();

                    foreach (var item in db.Accumulations)
                    {


                        if (item.UserId == _idUserForTabMenu &&
                            item.DateTimeAccumulation == temp.DateTimeAccumulation &&
                            item.SummofAccumulation == temp.SummofAccumulation &&
                            item.AccumulationName == temp.AccumulationName &&
                            item.Accumulated == temp.Accumulated)
                        {
                            _accumulationForRemove = item;
                        }

                    }

                    db.Accumulations.Remove(_accumulationForRemove);
                    db.SaveChanges();

                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // DataGrid Update

            Functions.UpdateDataGridsTabMenu(dataGridAccumulation, user);
        }

        // Export to Excel

        private void btnExportToExcelCost_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGridCosts.SelectAllCells();
                dataGridCosts.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
                ApplicationCommands.Copy.Execute(null, dataGridCosts);
                String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
                String result = (string)Clipboard.GetData(DataFormats.Text);
                dataGridCosts.UnselectAllCells();
                System.IO.StreamWriter file1 = new System.IO.StreamWriter(@"..\Расходы.xls", true, Encoding.Default);
                file1.WriteLine(result.Replace(',', ' '));
                file1.Close();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Export to Excel

        private void btnExportToExcelIncome_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGridIncomes.SelectAllCells();
                dataGridIncomes.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
                ApplicationCommands.Copy.Execute(null, dataGridIncomes);
                String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
                String result = (string)Clipboard.GetData(DataFormats.Text);
                dataGridIncomes.UnselectAllCells();
                System.IO.StreamWriter file1 = new System.IO.StreamWriter(@"..\Доходы.xls", true, Encoding.Default);
                file1.WriteLine(result.Replace(',', ' '));
                file1.Close();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Export to Excel

        private void btnExportToExcelDebt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGridDebts.SelectAllCells();
                dataGridDebts.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
                ApplicationCommands.Copy.Execute(null, dataGridDebts);
                String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
                String result = (string)Clipboard.GetData(DataFormats.Text);
                dataGridDebts.UnselectAllCells();
                System.IO.StreamWriter file1 = new System.IO.StreamWriter(@"..\Долги.xls", true, Encoding.Default);
                file1.WriteLine(result.Replace(',', ' '));
                file1.Close();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Export to Excel

        private void btnExportToExcelAccumulation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGridAccumulation.SelectAllCells();
                dataGridAccumulation.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
                ApplicationCommands.Copy.Execute(null, dataGridAccumulation);
                String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
                String result = (string)Clipboard.GetData(DataFormats.Text);
                dataGridAccumulation.UnselectAllCells();
                System.IO.StreamWriter file1 = new System.IO.StreamWriter(@"..\Накопления.xls", true, Encoding.Default);
                file1.WriteLine(result.Replace(',', ' '));
                file1.Close();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Opening the statistics window

        private void btnOpenAnalyticsCost_Click(object sender, RoutedEventArgs e)
        {
            string str = "Cost";
            Analytics analytics = new Analytics(_idUserForTabMenu, str);
            analytics.Show();
            analytics.ShowInTaskbar = false;
        }

        // Opening the statistics window

        private void btnOpenAnalyticsIncome_Click(object sender, RoutedEventArgs e)
        {
            string str = "Income";
            Analytics analytics = new Analytics(_idUserForTabMenu, str);
            analytics.Show();
            analytics.ShowInTaskbar = false;
        }

        // Call calculator

        private void btnOpenCalc_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("calc");
        }
    }
}
