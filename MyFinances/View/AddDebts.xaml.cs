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
using MyFinances.Helpers;
using MyFinances.Models;

namespace MyFinances.View
{
    /// <summary>
    /// Логика взаимодействия для AddDebts.xaml
    /// </summary>
    public partial class AddDebts
    {
        private int _idUserForDebts;
        public AddDebts(int id)
        {
            InitializeComponent();

            _idUserForDebts = id;
        }

        private void btnAddDebts_Click(object sender, RoutedEventArgs e)
        {
            string formattedDate;
            double tempsumm;

            // Форматируем дату

            DateTime? tempdate = datePickerDebts.SelectedDate;
            if (tempdate.HasValue)
            {
                formattedDate = tempdate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            else formattedDate = "";

            // Форматируем сумму

            if (textBoxEnterSummDebt.Text == "")
            {
                tempsumm = 0.0;
            }
            else tempsumm = Convert.ToDouble(textBoxEnterSummDebt.Text);

            using (ApplicationContext db = new ApplicationContext())
            {

                db.Debts.Add(new Debt
                {
                    DebtName = textBoxEnterNameDebt.Text,
                    SummofDebt = tempsumm,
                    UserId = _idUserForDebts,
                    DateEndDate = formattedDate,
                });

                db.SaveChanges();

            }
            this.Close();
        }

        private void btnCancelAddDebts_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
