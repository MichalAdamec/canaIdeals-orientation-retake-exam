using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mountaineering.Models
{
    public class Climber
    {
        [Key, JsonIgnore]
        public int Id { get; set; }
        public string Climbers_Name { get; set; }
        public string Nationality { get; set; }
        public bool IsInjured { get; set; }
        public int Altitude { get; set; }
        [JsonIgnore]
        public int Mountain_Id { get; set; }

        public Mountain Mountain { get; set; }
    }
}
