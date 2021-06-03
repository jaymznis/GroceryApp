using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Models
{
    public class GroceryStoreEdit
    {
        public int GroceryStoreID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public int PhoneNumber { get; set; }
        public string App { get; set; }
        public string Hours { get; set; }
    }
}
