namespace cnxdevsoft_backend_assignment.Models.Responses
{
    public class MathCalculateResponse
    {
        public int X { get; set; }
        public int Y { get; set; }
        public required string Operator { get; set; }
        public double Result { get; set; }
    }
}
