using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Recipes.Models;

namespace Recipes.Controllers
{
    [RoutePrefix("api/Recipe")]
    public class RecipeController : ApiController
    {
        private static Recipe[] Recipes = new Recipe[]
        {
            new Recipe()
            {
                Id = 0,
                RecipeName = "Pilsner",
                RecipeText = "Ingredients: Barley, Hops, Yeast, Water. Directions: Mix well. Let ferment."
            },
            new Recipe()
            {
                Id = 1,
                RecipeName = "Wheat Ale",
                RecipeText = "Ingredients: Wheat, Hops, Yeast, Water. Red Dye #5. Directions: Mix well. Let ferment."
            },
            new Recipe()
            {
                Id = 2,
                RecipeName = "India Pale Ale",
                RecipeText = "Ingredients: Barley, Hops, Yeast, Water. Directions: Mix well. Let ferment."
            },
            new Recipe()
            {
                Id = 3,
                RecipeName = "English Style Bitter",
                RecipeText = "Ingredients: Barley, Hops, Yeast, Water. Directions: Mix well. Let ferment."
            }
        };

        // GET: api/Ingredient
        [Route("")]
        public IEnumerable<Recipe> Get()
        {
            return Recipes;
        }

        [Route("{name}")]
        [HttpGet]
        public IEnumerable<Recipe> FindRecipeByName(string name)
        {
            if(string.IsNullOrEmpty(name) || name == "undefined")
            {
                return Recipes;
            }
            else
            {
                Recipe[] RecipeArray = Recipes.Where<Recipe>(c => c.RecipeName.Contains(name)).ToArray<Recipe>();
                return RecipeArray;
            }
        }

        // POST: api/Recipe
        [Route("")]
        [HttpPost]
        public IEnumerable<Recipe> Post([FromBody]Recipe newRecipe)
        {
            List<Recipe> RecipeList = Recipes.ToList<Recipe>();
            newRecipe.Id = RecipeList.Count;
            RecipeList.Add(newRecipe);
            Recipes = RecipeList.ToArray();
            return RecipeList;
        }
    }
}

