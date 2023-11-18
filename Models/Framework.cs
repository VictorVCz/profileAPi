using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace profileAPi.Models
{
    public class Framework
    {
        [Key]
        public string FrameworkName { get; set; } = string.Empty;
        public string FrameworkDate { get; set; } = string.Empty;
        public string IsLearned { get; set; } = string.Empty;
    }
}