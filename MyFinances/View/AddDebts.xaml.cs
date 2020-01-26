using System;
using System.Windows;
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

            // Format date

            DateTime? tempdate = datePickerDebts.SelectedDate;
            if (tempdate.HasValue)
            {
                formattedDate = tempdate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            else formattedDate = "";

            // Format the amount

            if (textBoxEnterSummDebt.Text == "")
            {
                tempsumm = 0.0;
            }
            else tempsumm = Convert.ToDouble(textBoxEnterSummDebt.Text);

            try
            {
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
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnCancelAddDebts_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
