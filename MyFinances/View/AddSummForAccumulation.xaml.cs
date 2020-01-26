using System;
using System.Linq;
using System.Windows;
using MyFinances.Helpers;
using MyFinances.Models;

namespace MyFinances.View
{
    /// <summary>
    /// Логика взаимодействия для AddSummForAccumulation.xaml
    /// </summary>
    public partial class AddSummForAccumulation
    {
        private int _idUserForAddSummAccumulation;
        public AddSummForAccumulation(int id)
        {
            InitializeComponent();

            _idUserForAddSummAccumulation = id;

            Activated += AddSummForAccumulation_Activated;
        }

        private void AddSummForAccumulation_Activated(object sender, EventArgs e)
        {
            Functions.UpdateComboBoxAddAccumulation(comboBoxEnterNameAccumulation, _idUserForAddSummAccumulation);
        }

        private void btnAddSummAccumulation_Click(object sender, RoutedEventArgs e)
        {
            string tempAccumulationName;
            double tempsumm;

            // Format the cost

            if (textBoxAddSummAccumulation.Text == "")
            {
                tempsumm = 0.0;
            }
            else tempsumm = Convert.ToDouble(textBoxAddSummAccumulation.Text);

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    tempAccumulationName = comboBoxEnterNameAccumulation.SelectedItem.ToString();
                    Accumulation accumulation = db.Accumulations.FirstOrDefault(a => a.AccumulationName == tempAccumulationName);

                    if (accumulation != null)
                    {
                        accumulation.AccumulationName = tempAccumulationName;
                        accumulation.Contributed = tempsumm;
                        accumulation.Accumulated += tempsumm;
                        accumulation.UserId = _idUserForAddSummAccumulation;

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

        private void btnCancelAddSummAccumulation_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
