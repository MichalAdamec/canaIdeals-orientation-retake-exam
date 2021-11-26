using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mountaineering.Models
{
    public class Mountain
    {
        [Key, JsonIgnore]
        public int Id { get; set; }
        public string Mountain_Name { get; set; }
        [JsonIgnore]
        public int Height { get; set; }
        [JsonIgnore]
        public int Level { get; set; }
        [JsonIgnore]
        public string FirstAscent { get; set; }
        [JsonIgnore]

        public List<Climber> Climbers { get; set; }
    }
}
