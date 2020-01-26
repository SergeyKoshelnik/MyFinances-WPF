using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using MyFinances.Helpers;
using MyFinances.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
            try
            {
                List<Transaction> transactions;
                _selectedDate2 = dtPicker2.SelectedDate;
                dtPicker1.DisplayDate = (DateTime)_selectedDate2;
                dtPicker1.DisplayDateStart = _selectedDate2;

                // Axis Formatting

                var dayConfig = Mappers.Xy<DateModel>()
                    .X(dateModel => dateModel.DateTime.Ticks / (TimeSpan.FromDays(1).Ticks * 30.44))
                    .Y(dateModel => dateModel.Value);

                Formatter = value => new DateTime((long)(value * TimeSpan.FromDays(1).Ticks * 30.44)).ToString("M");

                // Receiving expenses or income of the User,
                // depending on the tab with which the call occurred

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

                    // A selection of expenses that are included in a given period

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
                    // Create line graph

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

                    // A selection of expenses that are included in a given period

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
                    // Create line graph

                    MySeriesCollection.Add(ln);
                    ln.Values = chartModels;

                    DataContext = this;
                }

            }

                catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
        }
            
        

}
}
