using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5WinForms.Models
{
    public class Manager
    {
        public int Id { get; set; }
        [Required]
        public string PIB { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
