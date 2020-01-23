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
    /// Логика взаимодействия для ManagerUsers.xaml
    /// </summary>
    public partial class ManagerUsers
    {
        private int _idUserForEdit;

        public ManagerUsers()
        {
            InitializeComponent();

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            // Заполнение/Обновление datagrid данными

            Functions.UpdateDataGrid(dataGrid);
        }

        // Удаление колонок кроме имени Пользователя
        private void dataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headerName = e.Column.Header.ToString();

            if (headerName == "Username")
            {
                e.Column.Header = "Пользователь";
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            addUser.ShowInTaskbar = false;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            // Активация кнопок "Редактировать" и "Удалить" при выбранном пользователе из списка

            if (dataGrid.SelectedItem != null)
            {
                btnEditUser.IsEnabled = true;
                btnDeleteUser.IsEnabled = true;
            }
            else
            {
                btnEditUser.IsEnabled = false;
                btnDeleteUser.IsEnabled = false;
            }
        }

        private void btnEditUser_Click(object sender, RoutedEventArgs e)
        {

            User user = dataGrid.SelectedItem as User;
            _idUserForEdit = user.Id;

            EditUser editUser = new EditUser(_idUserForEdit);
            editUser.Show();
            editUser.ShowInTaskbar = false;
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {

            // Удаление пользователя из списка

            using (ApplicationContext db = new ApplicationContext())
            {
                User temp = dataGrid.SelectedItem as User;
                _idUserForEdit = temp.Id;

                User user = db.Users.FirstOrDefault(u => u.Id == _idUserForEdit);

                db.Users.Remove(user);
                db.SaveChanges();

                // Обновление datagrid

                Functions.UpdateDataGrid(dataGrid);

            }

        }

        private void btnExitUsers_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
