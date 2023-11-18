using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace profileAPi.Models
{
    public class Hobby
    {
        [Key]
        public string HobbyName { get; set; } = string.Empty;
    }
}