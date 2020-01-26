using System.Linq;
using System.Windows;
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

            _idUserForQuestion = nameUser; // Getting username for checks

            Loaded += EnterQuestion_Loaded;
        }

        private void EnterQuestion_Loaded(object sender, RoutedEventArgs e)
        {

            // Display a security question in label

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    User user = db.Users.FirstOrDefault(u => u.Id == _idUserForQuestion);

                    lblQuestion.Text = "Вопрос: " + user.Question;
                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnterQuestionOK_Click(object sender, RoutedEventArgs e)
        {
            // Checking the correctness of the answer to the question

            try
            {
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

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnterQuestionExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
