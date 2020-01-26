using System.Windows;
using MyFinances.Helpers;
using MyFinances.Models;

namespace MyFinances.View
{
    /// <summary>
    /// Логика взаимодействия для AddCategory.xaml
    /// </summary>
    public partial class AddCategory
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnOKEnterCategory_Click(object sender, RoutedEventArgs e)
        {
            // Adding a new category

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {


                    db.Categories.Add(new Category
                    {
                        CategoryName = textBoxEnterCategory.Text
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

        private void btnCancelEnterCategory_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
