namespace cnxdevsoft_backend_assignment.Models.Requests
{
    public class MathCalculateRequest
    {
        public required int X { get; set; }
        public required int Y { get; set; }
        public required string Operator { get; set; }
    }
}
