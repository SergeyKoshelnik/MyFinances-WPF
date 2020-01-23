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
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser
    {
        public AddUser()
        {
            InitializeComponent();

        }

        private void btnEnterAddUser_Click(object sender, RoutedEventArgs e)
        {

            // Проверка заполнения полей данными

            if (textBoxEnterNameUser.Text == "" || passwordBoxEnterPassword.Password == "" || passwordBoxEnterPasswordAgain.Password == "" ||
                textBoxEnterQuestion.Text == "" || textBoxEnterResponse.Text == "")
            {
                ErrorFieldsDontFilled errorFieldsDontFilled = new ErrorFieldsDontFilled();
                errorFieldsDontFilled.ShowDialog();
                return;
            }

            if (passwordBoxEnterPassword.Password != passwordBoxEnterPasswordAgain.Password)
            {
                ErrorPasswordsDontEqual errorPasswordsDontEqual = new ErrorPasswordsDontEqual();
                errorPasswordsDontEqual.ShowDialog();
                return;
            }


            // Добавление пользователя в базу данных

            using (ApplicationContext db = new ApplicationContext())
            {

                db.Users.Add(new User
                {
                    Username = textBoxEnterNameUser.Text,
                    Password = passwordBoxEnterPassword.Password,
                    Balance = 500.0,
                    Question = textBoxEnterQuestion.Text,
                    Answer = textBoxEnterResponse.Text
                });

                db.SaveChanges();

            }

            this.Close();

        }
        private void btnExitAddUser_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
