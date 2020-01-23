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
    /// Логика взаимодействия для EnterQuestion.xaml
    /// </summary>
    public partial class EnterQuestion
    {

        private int _idUserForQuestion;

        public EnterQuestion(int nameUser)
        {
            InitializeComponent();

            _idUserForQuestion = nameUser; // Получение имя пользователя для проверок

            Loaded += EnterQuestion_Loaded;
        }

        private void EnterQuestion_Loaded(object sender, RoutedEventArgs e)
        {

            // Выведение в label контрольного вопроса

            using (ApplicationContext db = new ApplicationContext())
            {
                User user = db.Users.FirstOrDefault(u => u.Id == _idUserForQuestion);

                lblQuestion.Text = "Вопрос: " + user.Question;
            }
        }

        private void btnEnterQuestionOK_Click(object sender, RoutedEventArgs e)
        {
            // Проверка на правильность ответа на вопрос

            using (ApplicationContext db = new ApplicationContext())
            {

                User user = db.Users.FirstOrDefault(u => u.Id == _idUserForQuestion);

                if (textBoxEnterQuestion.Text == user.Answer)
                {

                    ViewPassword viewPassword = new ViewPassword(user.Password);
                    viewPassword.ShowDialog();
                    viewPassword.ShowInTaskbar = false;
                    this.Close();
                }
                else
                {
                    textBoxEnterQuestion.Clear();
                    ErrorQuestion errorQuestion = new ErrorQuestion();
                    errorQuestion.ShowDialog();
                    errorQuestion.ShowInTaskbar = false;
                }
            }
        }

        private void btnEnterQuestionExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
