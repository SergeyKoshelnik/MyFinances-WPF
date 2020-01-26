using System.Linq;
using System.Windows;
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

            // Filling form fields with initial User data


            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    User user = db.Users.FirstOrDefault(u => u.Id == _idForEdit);

                    textBoxEditNameUser.Text = user.Username;
                    textBoxEditQuestion.Text = user.Question;
                    textBoxEditResponse.Text = user.Answer;
                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            // Open a connection to the database and perform user editing

            try
            {
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
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnExitEditUser_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
