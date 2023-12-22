using System.Text.Json.Serialization;

namespace cnxdevsoft_backend_assignment.Models.Requests
{
    public class MathCalculateRequest
    {
        [JsonRequired]
        public required int X { get; set; }
        [JsonRequired]
        public required int Y { get; set; }
        [JsonRequired]
        public required string Operator { get; set; }
    }
}
