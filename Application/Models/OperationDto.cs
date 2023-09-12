namespace Application.Models
{
    public class OperationDto
    {
        public long Id { get; set; }
        public decimal FirstValue { get; set; }
        public decimal SecondValue { get; set; }
        public decimal Result { get; set; }
        public string Operator { get; set; }
    }
}
