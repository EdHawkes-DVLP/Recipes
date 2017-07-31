using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipes.Models
{
    public class Ingredient
    {
        public int Id { get; set; }       
        public string IngredientName { get; set; }

        public Ingredient()
        {
            Id = -1;
            IngredientName = string.Empty;
        }
    }
}

