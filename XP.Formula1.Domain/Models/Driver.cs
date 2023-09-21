using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XP.Formula1.Domain.Enums;

namespace XP.Formula1.Domain.Models
{
    public class Driver
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Car { get; set; }
        public int Wins { get; set; }
        public int Points { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Nationality Nationality { get; set; }
    }
}
