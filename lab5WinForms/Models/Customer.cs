using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5WinForms.Models
{
    class Customer
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

     /*   public Customer(string PIB, string Date_of_birth, string Gender, string Plase_of_esidence)
        {
            this.PIB = PIB;
            this.Date_of_birth = Date_of_birth;
            this.Gender = Gender;
            this.Plase_of_esidence = Plase_of_esidence;
        }*/
    }
}
