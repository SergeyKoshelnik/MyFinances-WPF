using System;
using System.Linq;
using System.Windows;
using MyFinances.Helpers;
using MyFinances.Models;

namespace MyFinances.View
{
    /// <summary>
    /// Логика взаимодействия для AddIncomes.xaml
    /// </summary>
    public partial class AddIncomes
    {
        private int _idUserForIncomes;
        public AddIncomes(int id)
        {
            InitializeComponent();

            _idUserForIncomes = id;
        }

        private void btnAddIncomes_Click(object sender, RoutedEventArgs e)
        {
            string formattedDate;
            double tempsumm;

            // Format date

            DateTime? tempdate = datePickerIncomes.SelectedDate;
            if (tempdate.HasValue)
            {
                formattedDate = tempdate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            else formattedDate = "";

            // Format the amount

            if (textBoxEnterSumm.Text == "")
            {
                tempsumm = 0.0;
            }
            else tempsumm = Convert.ToDouble(textBoxEnterSumm.Text);

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {

                    db.Transactions.Add(new Transaction
                    {
                        CommentforCategory = textBoxEnterComment.Text,
                        DateTimeTransaction = formattedDate,
                        Income = tempsumm,
                        UserId = _idUserForIncomes,
                    });


                    // Updating User balance

                    User user = db.Users.FirstOrDefault(u => u.Id == _idUserForIncomes);

                    user.Balance += tempsumm;

                    db.SaveChanges();
                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnCancelAddIncomes_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
