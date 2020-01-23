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

            // Форматируем дату

            DateTime? tempdate = datePickerIncomes.SelectedDate;
            if (tempdate.HasValue)
            {
                formattedDate = tempdate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            else formattedDate = "";

            // Форматируем сумму

            if (textBoxEnterSumm.Text == "")
            {
                tempsumm = 0.0;
            }
            else tempsumm = Convert.ToDouble(textBoxEnterSumm.Text);

            using (ApplicationContext db = new ApplicationContext())
            {

                db.Transactions.Add(new Transaction
                {
                    CommentforCategory = textBoxEnterComment.Text,
                    DateTimeTransaction = formattedDate,
                    Income = tempsumm,
                    UserId = _idUserForIncomes,
                });


                // Обновляем баланс Пользователя

                User user = db.Users.FirstOrDefault(u => u.Id == _idUserForIncomes);

                user.Balance += tempsumm;

                db.SaveChanges();
            }
            this.Close();
        }

        private void btnCancelAddIncomes_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
