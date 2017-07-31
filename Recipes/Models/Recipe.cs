using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipes.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public string RecipeText { get; set; }

        public Recipe()
        {
            Id = -1;
            RecipeName = string.Empty;
            RecipeText = string.Empty;         
        }
    }
}

