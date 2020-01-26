using MyFinances.Helpers;
using MyFinances.Models;
using MyFinances.View;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace MyFinances
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private int idUserForPassword;

        private bool _ShowingDialog;
        private bool _AllowClose;

        public MainWindow()
        {
            DataContext = new MainWindowViewModel();
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            // Update / Fill combobox when MainWindow is activated

            Functions.UpdateComboBox(comboBoxUsers);
        }

        private void btnManagerUsers_Click(object sender, RoutedEventArgs e)
        {
            ManagerUsers managerUsers = new ManagerUsers();
            managerUsers.Show();
            managerUsers.ShowInTaskbar = false;
        }

        private void btnApplyUser_Click(object sender, RoutedEventArgs e)
        {
            // Getting a user and checking for a password


            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    string tempName = comboBoxUsers.SelectedItem.ToString();

                    User user = db.Users.FirstOrDefault(u => u.Username == tempName);

                    idUserForPassword = user.Id; // Getting User Id

                    if (passwordBoxApplyPassword.Password == user.Password)
                    {
                        TabMenu tabMenu = new TabMenu(idUserForPassword);
                        tabMenu.Show();
                        tabMenu.ShowInTaskbar = false;
                    }
                    else
                    {
                        passwordBoxApplyPassword.Clear();
                        ErrorPassword errorPassword = new ErrorPassword(idUserForPassword);
                        errorPassword.ShowDialog();
                        errorPassword.ShowInTaskbar = false;

                    }
                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExitMainWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Question-confirmation to exit the application

        protected override async void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);


            if (_AllowClose) return;


            e.Cancel = true;


            if (_ShowingDialog) return;

            TextBlock txt1 = new TextBlock();
            txt1.HorizontalAlignment = HorizontalAlignment.Center;
            txt1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF53B3B"));
            txt1.Margin = new Thickness(4);
            txt1.TextWrapping = TextWrapping.WrapWithOverflow;
            txt1.FontSize = 18;
            txt1.Text = "Вы уверены?";

            Button btn1 = new Button();
            Style style = Application.Current.FindResource("MaterialDesignFlatButton") as Style;
            btn1.Style = style;
            btn1.Width = 115;
            btn1.Height = 30;
            btn1.Margin = new Thickness(5);
            btn1.Command = MaterialDesignThemes.Wpf.DialogHost.CloseDialogCommand;
            btn1.CommandParameter = true;
            btn1.Content = "Да";

            Button btn2 = new Button();
            Style style2 = Application.Current.FindResource("MaterialDesignFlatButton") as Style;
            btn2.Style = style2;
            btn2.Width = 115;
            btn2.Height = 30;
            btn2.Margin = new Thickness(5);
            btn2.Command = MaterialDesignThemes.Wpf.DialogHost.CloseDialogCommand;
            btn2.CommandParameter = false;
            btn2.Content = "Нет";


            DockPanel dck = new DockPanel();
            dck.Children.Add(btn1);
            dck.Children.Add(btn2);

            StackPanel stk = new StackPanel();
            stk.Width = 250;
            stk.Children.Add(txt1);
            stk.Children.Add(dck);

            
            _ShowingDialog = true;
            object result = await MaterialDesignThemes.Wpf.DialogHost.Show(stk);

            _ShowingDialog = false;
            
            if (result is bool boolResult && boolResult)
            {
                _AllowClose = true;
                Close();
            }
        }


    }
}
