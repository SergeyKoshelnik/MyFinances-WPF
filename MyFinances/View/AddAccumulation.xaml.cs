using MyFinances.Helpers;
using MyFinances.Models;
using System;
using System.Windows;

namespace MyFinances.View
{
    /// <summary>
    /// Логика взаимодействия для AddAccumulation.xaml
    /// </summary>
    public partial class AddAccumulation
    {
        private int _idUserForAccumulation;
        public AddAccumulation(int id)
        {
            InitializeComponent();

            _idUserForAccumulation = id;
        }

        private void btnAddAccumulation_Click(object sender, RoutedEventArgs e)
        {
            string formattedDate;
            double tempsumm;

            // Format date

            DateTime? tempdate = datePickerAccumulation.SelectedDate;
            if (tempdate.HasValue)
            {
                formattedDate = tempdate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            else formattedDate = "";

            // Format the cost

            if (textBoxEnterSummAccumulation.Text == "")
            {
                tempsumm = 0.0;
            }
            else tempsumm = Convert.ToDouble(textBoxEnterSummAccumulation.Text);

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    db.Accumulations.Add(new Accumulation
                    {
                        DateTimeAccumulation = formattedDate,
                        AccumulationName = textBoxEnterNameAccumulation.Text,
                        SummofAccumulation = tempsumm,
                        Contributed = 0.0,
                        Accumulated = 0.0,
                        UserId = _idUserForAccumulation
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

        private void btnCancelAddAccumulation_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
