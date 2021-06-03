using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Data
{
    public class Ingredients
    {
        [Key]
        public int IngredientID { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey(nameof(Recipies))]
        public int RecipieID { get; set; }
        public virtual Recipies Recipies { get; set }

        public double ServingSize { get; set; }
    }
}
