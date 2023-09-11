namespace Core.Entities
{
    public class Operation
    {
        public long Id { get; set; }
        public string Operator { get; set; }
        public float FirstValue { get; set; }
        public float? SecondValue { get; set; }
        public float Result { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
