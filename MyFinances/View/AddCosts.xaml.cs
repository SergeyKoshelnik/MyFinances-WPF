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
    /// Логика взаимодействия для AddCosts.xaml
    /// </summary>
    public partial class AddCosts
    {
        private int _idUserForCosts;
        private int _idCategoryForTransaction;

        public AddCosts(int id)
        {
            InitializeComponent();

            _idUserForCosts = id;

            Activated += AddCosts_Activated;
        }

        private void AddCosts_Activated(object sender, EventArgs e)
        {
            Functions.UpdateComboBox(comboBoxSelectCategory);
        }

        private void EnterCategory_Click(object sender, RoutedEventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            addCategory.ShowInTaskbar = false;
        }

        private void btnAddCosts_Click(object sender, RoutedEventArgs e)
        {
            string tempCategory = comboBoxSelectCategory.SelectedItem.ToString();
            string formattedDate;
            double tempsumm;


            // Форматируем дату

            DateTime? tempdate = datePickerCosts.SelectedDate;
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
                Category category = db.Categories.FirstOrDefault(c => c.CategoryName == tempCategory);
                _idCategoryForTransaction = category.Id; // Получение Id категории

                db.Transactions.Add(new Transaction
                {
                    CommentforCategory = textBoxEnterComment.Text,
                    DateTimeTransaction = formattedDate,
                    Cost = tempsumm,
                    UserId = _idUserForCosts,
                    CategoryId = _idCategoryForTransaction
                });


                // Обновляем баланс Пользователя

                User user = db.Users.FirstOrDefault(u => u.Id == _idUserForCosts);

                user.Balance -= tempsumm;

                db.SaveChanges();
            }
            this.Close();
        }

        private void btnCancelAddCosts_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
