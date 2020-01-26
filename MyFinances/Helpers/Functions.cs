using MyFinances.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MyFinances.Helpers
{
    // Functions for updating DataGrids and ComboBoxes

    static class Functions
    {
        internal static DataGrid UpdateDataGrid(DataGrid dt)
        {

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    List<User> listUsers = new List<User>();

                    foreach (var item in db.Users)
                    {
                        listUsers.Add(item);
                    }

                    dt.ItemsSource = null;
                    dt.ItemsSource = listUsers;
                }
                
            }
            
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;

        }

        internal static DataGrid UpdateDataGridsTabMenu(DataGrid dt, User us)
        {
            if (dt.Name == "dataGridCosts")
            {
                int _idUserForDataGridCosts = us.Id;
                string tempDateTimeTransaction = null;
                double tempCost = 0.0;
                double tempIncome = 0.0;
                string tempCategoryName = null;
                string tempCommentforCategory = null;

                Category category = new Category();
                List<Transaction> transactions = new List<Transaction>();
                List<Category> categories = new List<Category>();

                // Create a common sheet for two tables

                List<TransactionsPlusCategory> trPluscat = new List<TransactionsPlusCategory>();

                try
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {

                        // A collection for selecting the expenses of the User on the received UserId

                        List<Transaction> tempTransactions = new List<Transaction>();

                        foreach (var item in db.Transactions)
                        {
                            if (item.UserId == _idUserForDataGridCosts)
                            {
                                if (item.Income == 0.0)
                                {
                                    tempTransactions.Add(item);
                                }

                            }
                        }

                        foreach (var item in tempTransactions)
                        {
                            // Filling the collection to add costs to the DataGrid

                            transactions.Add(item);

                            tempDateTimeTransaction = item.DateTimeTransaction;
                            tempCost = item.Cost;
                            tempIncome = item.Income;
                            tempCommentforCategory = item.CommentforCategory;

                            category = db.Categories.FirstOrDefault(c => c.Id == item.CategoryId);
                            categories.Add(category);

                            tempCategoryName = category.CategoryName;

                            TransactionsPlusCategory transactionsPlusCategory =
                            new TransactionsPlusCategory(
                            tempDateTimeTransaction,
                            tempCost,
                            tempIncome,
                            tempCategoryName,
                            tempCommentforCategory
                            );

                            trPluscat.Add(transactionsPlusCategory);
                        }
                        dt.ItemsSource = null;
                        dt.ItemsSource = trPluscat;
                    }
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (dt.Name == "dataGridIncomes")
            {
                int _idUserForDataGridIncomes = us.Id;
                string tempDateTimeTransaction = null;
                double tempCost = 0.0;
                double tempIncome = 0.0;
                string tempCategoryName = null;
                string tempCommentforCategory = null;

                List<Transaction> transactions = new List<Transaction>();

                try
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {

                        // A collection for selecting the expenses of the User on the received UserId

                        List<Transaction> tempTransactions = new List<Transaction>();

                        foreach (var item in db.Transactions)
                        {
                            if (item.UserId == _idUserForDataGridIncomes)
                            {
                                if (item.Cost == 0.0)
                                {
                                    tempTransactions.Add(item);
                                }

                            }
                        }

                        foreach (var item in tempTransactions)
                        {
                            // Filling the collection to add costs to the DataGrid

                            transactions.Add(item);

                            tempDateTimeTransaction = item.DateTimeTransaction;
                            tempCost = item.Cost;
                            tempIncome = item.Income;
                            tempCommentforCategory = item.CommentforCategory;

                            TransactionsPlusCategory transactionsPlusCategory =
                            new TransactionsPlusCategory(
                            tempDateTimeTransaction,
                            tempCost,
                            tempIncome,
                            tempCategoryName,
                            tempCommentforCategory
                            );

                        }
                        dt.ItemsSource = null;
                        dt.ItemsSource = transactions;
                    }
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (dt.Name == "dataGridDebts")
            {
                int _idUserForDataGridDebts = us.Id;

                List<Debt> debts = new List<Debt>();

                try
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {

                        // Collection for the selection of the debtors of the User received UserId

                        List<Debt> tempDebts = new List<Debt>();

                        foreach (var item in db.Debts)
                        {
                            if (item.UserId == _idUserForDataGridDebts)
                            {
                                tempDebts.Add(item);
                            }
                        }

                        dt.ItemsSource = null;
                        dt.ItemsSource = tempDebts;
                    }
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (dt.Name == "dataGridAccumulation")
            {
                int _idUserForDataGridAccumulation = us.Id;

                List<Accumulation> accumulations = new List<Accumulation>();

                try
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {

                        // A collection for sampling the user's planned purchases based on the received UserId

                        List<Accumulation> tempAccumulations = new List<Accumulation>();

                        foreach (var item in db.Accumulations)
                        {
                            if (item.UserId == _idUserForDataGridAccumulation)
                            {
                                tempAccumulations.Add(item);
                            }
                        }

                        dt.ItemsSource = null;
                        dt.ItemsSource = tempAccumulations;
                    }
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return dt;
        }

        internal static ComboBox UpdateComboBox(ComboBox cb)
        {
            if (cb.Name == "comboBoxUsers")
            {
                cb.Items.Clear();

                // Combobox filling

                try
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {

                        User user = db.Users.FirstOrDefault();


                        cb.SelectedItem = user.Username;

                        foreach (var item in db.Users)
                        {
                            cb.Items.Add(item.Username);
                        }

                    }
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (cb.Name == "comboBoxSelectCategory")
            {
                cb.Items.Clear();

                try
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {

                        Category category = db.Categories.FirstOrDefault();

                        cb.SelectedItem = category.CategoryName;

                        foreach (var item in db.Categories)
                        {
                            cb.Items.Add(item.CategoryName);
                        }

                    }
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return cb;
        }

        internal static ComboBox UpdateComboBoxAddAccumulation(ComboBox cb, int id)
        {
            if (cb.Name == "comboBoxEnterNameAccumulation")
            {
                int tempId = id;
                cb.Items.Clear();

                // Combobox filling

                try
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        Accumulation accumulation = db.Accumulations.FirstOrDefault(a => a.UserId == tempId);

                        cb.SelectedItem = accumulation.AccumulationName;

                        foreach (var item in db.Accumulations)
                        {
                            cb.Items.Add(item.AccumulationName);
                        }

                    }
                }

                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return cb;
        }
    }
}
