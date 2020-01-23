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
