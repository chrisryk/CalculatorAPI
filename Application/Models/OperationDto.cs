namespace Application.Models
{
    public class OperationDto
    {
        public long Id { get; set; }
        public float FirstValue { get; set; }
        public float SecondValue { get; set; }
        public float Result { get; set; }
        public string Operator { get; set; }
    }
}
