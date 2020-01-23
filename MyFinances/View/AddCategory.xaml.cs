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
            // Добавление новой категории

            using (ApplicationContext db = new ApplicationContext())
            {


                db.Categories.Add(new Category
                {
                    CategoryName = textBoxEnterCategory.Text
                });

                db.SaveChanges();

            }
            this.Close();
        }

        private void btnCancelEnterCategory_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
