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
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser
    {
        private int _idForEdit;
        public EditUser(int nameUser)
        {
            InitializeComponent();

            _idForEdit = nameUser;

            Loaded += EditUser_Loaded;
        }

        private void EditUser_Loaded(object sender, RoutedEventArgs e)
        {

            // Заполнение полей формы изначальными данными пользователя

            using (ApplicationContext db = new ApplicationContext())
            {
                User user = db.Users.FirstOrDefault(u => u.Id == _idForEdit);

                textBoxEditNameUser.Text = user.Username;
                textBoxEditQuestion.Text = user.Question;
                textBoxEditResponse.Text = user.Answer;
            }

        }

        private void btnEditUser_Click(object sender, RoutedEventArgs e)
        {

            if (textBoxEditNameUser.Text == "" || passwordBoxEditPassword.Password == "" || passwordBoxEditPasswordAgain.Password == "" ||
                textBoxEditQuestion.Text == "" || textBoxEditResponse.Text == "")
            {
                ErrorFieldsDontFilled errorFieldsDontFilled = new ErrorFieldsDontFilled();
                errorFieldsDontFilled.ShowDialog();
                return;
            }

            if (passwordBoxEditPassword.Password != passwordBoxEditPasswordAgain.Password)
            {
                passwordBoxEditPassword.Clear();
                passwordBoxEditPasswordAgain.Clear();

                ErrorPasswordsDontEqual errorPasswordsDontEqual = new ErrorPasswordsDontEqual();
                errorPasswordsDontEqual.ShowDialog();
                return;
            }

            // Открываем соединение с базой и выполняем редактирование пользователя

            using (ApplicationContext db = new ApplicationContext())
            {
                User user = db.Users.FirstOrDefault(u => u.Id == _idForEdit);

                if (user != null)
                {
                    user.Username = textBoxEditNameUser.Text;
                    user.Password = passwordBoxEditPassword.Password;
                    user.Question = textBoxEditQuestion.Text;
                    user.Answer = textBoxEditResponse.Text;

                    db.SaveChanges();
                }
            }
            this.Close();
        }

        private void btnExitEditUser_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
