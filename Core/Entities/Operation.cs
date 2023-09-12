namespace Core.Entities
{
    public class Operation
    {
        public long Id { get; set; }
        public string Operator { get; set; }
        public decimal FirstValue { get; set; }
        public decimal? SecondValue { get; set; }
        public decimal Result { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
