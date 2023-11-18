using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace profileAPi.Models
{
    public class Profile
    {
        [Key]
        public string Name { get; set; } = string.Empty;

        public string Lastname { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        
        public int Age { get; set; }

        public string Country { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Summary { get; set; } = string.Empty;
        
        public List<Framework> Frameworks { get; set; } = new List<Framework>();

        public List<Hobby> Hobbies { get; set; } = new List<Hobby>();
    }
}