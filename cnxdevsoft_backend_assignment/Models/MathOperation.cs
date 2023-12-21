using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text.Json.Serialization;

namespace cnxdevsoft_backend_assignment.Models
{
    public class MathOperation
    {
        [Key]
        public Int64 Id { get; set; }
        [JsonRequired]
        public required int X { get; set; }
        [JsonRequired]
        public required int Y { get; set; }
        [JsonRequired]
        public required string Operator { get; set; }
        [JsonRequired]
        public required double Result { get; set; }
    }
}
