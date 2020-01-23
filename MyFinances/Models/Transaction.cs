using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinances.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public string DateTimeTransaction { get; set; }
        public double Cost { get; set; }

        public double Income { get; set; }

        public string CommentforCategory { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }
    }
}
