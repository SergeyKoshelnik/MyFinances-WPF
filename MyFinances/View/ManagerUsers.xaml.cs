using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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
            // Filling / Updating a datagrid with Data

            Functions.UpdateDataGrid(dataGrid);
        }

        // Removing columns other than the username
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

            // Activation of the "Edit" and "Delete" buttons with the selected user from the list

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

            // Removing a User from the list

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    User temp = dataGrid.SelectedItem as User;
                    _idUserForEdit = temp.Id;

                    User user = db.Users.FirstOrDefault(u => u.Id == _idUserForEdit);

                    db.Users.Remove(user);
                    db.SaveChanges();

                    // Datagrid update

                    Functions.UpdateDataGrid(dataGrid);

                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExitUsers_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
