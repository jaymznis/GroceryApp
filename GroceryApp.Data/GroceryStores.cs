using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Data
{
    public class GroceryStores
    {
        [Key]
        public int GroceryStoreID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public int PhoneNumber { get; set; }
        public string App { get; set; }
        public string Hours { get; set; }
    }
}
