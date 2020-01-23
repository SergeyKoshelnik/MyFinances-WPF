using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinances.Models
{
    public class TransactionsPlusCategory
    {
        public string DateTimeTransaction { get; set; }
        public double Cost { get; set; }

        public double Income { get; set; }

        public string CategoryName { get; set; }

        public string CommentforCategory { get; set; }

        public TransactionsPlusCategory(string dt, double cost, double inc, string ctname, string comm)
        {
            DateTimeTransaction = dt;
            Cost = cost;
            Income = inc;
            CategoryName = ctname;
            CommentforCategory = comm;
        }
    }
}
