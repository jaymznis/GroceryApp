using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Data
{
    public class Recipies
    {
        [Key]
        public int RecipiesID { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual List<Ingredients> Ingredients { get; set; }
        public double ServingSize { get; set; }

    }
}
