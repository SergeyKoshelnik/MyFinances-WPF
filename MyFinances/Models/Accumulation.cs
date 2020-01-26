namespace MyFinances.Models
{
    public class Accumulation
    {
        public int Id { get; set; }

        public string DateTimeAccumulation { get; set; }

        public string AccumulationName { get; set; }

        public double SummofAccumulation { get; set; }

        public double Contributed { get; set; }

        public double Accumulated { get; set; }

        public string CommentforAccumulation { get; set; }

        public int UserId { get; set; }
    }
}
