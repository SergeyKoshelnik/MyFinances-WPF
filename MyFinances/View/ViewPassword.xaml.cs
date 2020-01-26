namespace MyFinances.View
{
    /// <summary>
    /// Логика взаимодействия для ViewPassword.xaml
    /// </summary>
    public partial class ViewPassword
    {
        public ViewPassword(string pass)
        {
            InitializeComponent();

            txtBlockViewPassword.Text = "Ваш пароль: " + pass;
            
        }
    }
}
