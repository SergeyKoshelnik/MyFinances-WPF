using System.Windows;
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

            // Checking the filling of fields with data

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


            // Adding a User to the database

            try
            {
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
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();

        }
        private void btnExitAddUser_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
