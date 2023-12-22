using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace cnxdevsoft_backend_assignment.Models
{
    public class MathOperation
    {
        [Key]
        public Int64 Id { get; set; }

        [JsonRequired]
        [Required(ErrorMessage = "Please enter {0}.")]
        public int X { get; set; }

        [JsonRequired]
        [Required(ErrorMessage = "Please enter {0}.")]
        public int Y { get; set; }

        [JsonRequired]
        [Required(ErrorMessage = "Please select {0}.")]
        public string? Operator { get; set; }

        public double Result { get; set; }
    }
}
