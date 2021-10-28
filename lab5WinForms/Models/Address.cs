using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5WinForms.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Building { get; set; }
        public string FullAddress 
        {
            get
            {
                return Region + ' ' + City + ' ' + Street + ' ' + Building;
            }
        }
    }
}
