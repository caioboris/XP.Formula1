using System.Text.Json.Serialization;
using XP.Formula1.Models.Enums;

namespace XP.Formula1.Models
{
    public class Driver
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Car { get; set; } = string.Empty;
        public int Points { get; set; }
        public int Wins { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Nationality Nationality { get; set; }

    }
}
