using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5WinForms.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string PIB { get; set; }
        [Required]
        public string Date_of_birth { get; set; }
        [Required]
        public string Gender { get;set; }
        [Required]
        public string Plase_of_esidence { get; set; }
    }
}
