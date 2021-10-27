using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5WinForms.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string P_name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string P_description { get; set; }
        [Required]
        public int ManagerId { get; set; }
    }
}
