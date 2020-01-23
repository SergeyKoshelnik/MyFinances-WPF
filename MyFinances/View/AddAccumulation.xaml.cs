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

            // Форматируем дату

            DateTime? tempdate = datePickerAccumulation.SelectedDate;
            if (tempdate.HasValue)
            {
                formattedDate = tempdate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            else formattedDate = "";

            // Форматируем стоимость

            if (textBoxEnterSummAccumulation.Text == "")
            {
                tempsumm = 0.0;
            }
            else tempsumm = Convert.ToDouble(textBoxEnterSummAccumulation.Text);

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
            this.Close();
        }

        private void btnCancelAddAccumulation_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
