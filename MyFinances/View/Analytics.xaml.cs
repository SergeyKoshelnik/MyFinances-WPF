using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using MyFinances.Helpers;
using MyFinances.Models;
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

namespace MyFinances.View
{
    /// <summary>
    /// Логика взаимодействия для Analytics.xaml
    /// </summary>
    public partial class Analytics
    {
        private int _idUserForAnalytics;
        private bool flagCost = false;
        private bool flagIncome = false;

        DateTime? _selectedDate1;
        DateTime? _selectedDate2;

        public SeriesCollection MySeriesCollection { get; set; }
        public Func<double, string> Formatter { get; set; }

        public Analytics(int id, string flag)
        {
            InitializeComponent();

            _idUserForAnalytics = id;

            if (flag == "Cost")
            {
                flagCost = true;
                flagIncome = false;
            }
            if (flag == "Income")
            {
                flagCost = false;
                flagIncome = true;
            }
        }

        private void dtPicker1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedDate1 = dtPicker1.SelectedDate;
            dtPicker2.DisplayDate = (DateTime)_selectedDate1;
            dtPicker2.DisplayDateStart = _selectedDate1;
        }

        private void dtPicker2_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Transaction> transactions;
            _selectedDate2 = dtPicker2.SelectedDate;
            dtPicker1.DisplayDate = (DateTime)_selectedDate2;
            dtPicker1.DisplayDateStart = _selectedDate2;

            // Форматирование осей

            var dayConfig = Mappers.Xy<DateModel>()
                .X(dateModel => dateModel.DateTime.Ticks / (TimeSpan.FromDays(1).Ticks * 30.44))
                .Y(dateModel => dateModel.Value);

            Formatter = value => new DateTime((long)(value * TimeSpan.FromDays(1).Ticks * 30.44)).ToString("M");

            // Получение расходов или доходов Пользователя в зависимости от вкладки с которой
            // произошел вызов

            if (flagCost == true)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    transactions = new List<Transaction>();

                    foreach (var item in db.Transactions)
                    {
                        if (item.UserId == _idUserForAnalytics && item.Cost > 0.0)
                        {
                            transactions.Add(item);
                        }
                    }

                }

                MySeriesCollection = new SeriesCollection(dayConfig);
                LineSeries ln = new LineSeries();
                ChartValues<DateModel> chartModels = new ChartValues<DateModel>();

                DateTime tempDate;

                // Выборка расходов, которые входят в заданный период

                foreach (var item in transactions)
                {
                    tempDate = Convert.ToDateTime(item.DateTimeTransaction);

                    if (tempDate >= (DateTime)_selectedDate1 && tempDate <= (DateTime)_selectedDate2)
                    {
                        chartModels.Add(new DateModel
                        {
                            DateTime = tempDate,
                            Value = item.Cost
                        });
                    }
                }
                // Создание линии графика

                MySeriesCollection.Add(ln);
                ln.Values = chartModels;

                DataContext = this;
            }

            if (flagIncome == true)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    transactions = new List<Transaction>();

                    foreach (var item in db.Transactions)
                    {
                        if (item.UserId == _idUserForAnalytics && item.Income > 0.0)
                        {
                            transactions.Add(item);
                        }
                    }

                }

                MySeriesCollection = new SeriesCollection(dayConfig);
                LineSeries ln = new LineSeries();
                ChartValues<DateModel> chartModels = new ChartValues<DateModel>();

                DateTime tempDate;

                // Выборка расходов, которые входят в заданный период

                foreach (var item in transactions)
                {
                    tempDate = Convert.ToDateTime(item.DateTimeTransaction);

                    if (tempDate >= (DateTime)_selectedDate1 && tempDate <= (DateTime)_selectedDate2)
                    {
                        chartModels.Add(new DateModel
                        {
                            DateTime = tempDate,
                            Value = item.Income
                        });
                    }
                }
                // Создание линии графика

                MySeriesCollection.Add(ln);
                ln.Values = chartModels;

                DataContext = this;
            }

            
        }

    }
}
