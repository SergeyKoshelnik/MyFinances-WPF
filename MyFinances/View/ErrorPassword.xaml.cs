using System.Windows;

namespace MyFinances.View
{
    /// <summary>
    /// Логика взаимодействия для ErrorPassword.xaml
    /// </summary>
    public partial class ErrorPassword
    {
        private int _idUserForPassword;
        public ErrorPassword(int id)
        {
            InitializeComponent();

            _idUserForPassword = id;
        }

        private void btnEnterQuestion_Click(object sender, RoutedEventArgs e)
        {
            EnterQuestion enterQuestion = new EnterQuestion(_idUserForPassword);
            enterQuestion.ShowDialog();
            enterQuestion.ShowInTaskbar = false;
            this.Close();
        }
    }
}
