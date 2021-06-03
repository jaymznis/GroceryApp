using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Models
{
    public class GroceryStoreCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public int PhoneNumber { get; set; }
        public string App { get; set; }
        public string Hours { get; set; }
    }
}
