using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Recipes.Models;

namespace Recipes.Controllers
{
    [RoutePrefix("api/Ingredient")]
    public class IngredientController : ApiController
    {
        Ingredient[] Ingredients = new Ingredient[]
        {
            new Ingredient() { Id = 0, IngredientName = "Hops"},
            new Ingredient() { Id = 1, IngredientName = "Barley"},
            new Ingredient() { Id = 2, IngredientName = "Yeast"},
            new Ingredient() { Id = 3, IngredientName = "Water"},
            new Ingredient() { Id = 4, IngredientName = "Wheat"},
            new Ingredient() { Id = 5, IngredientName = "Red Dye #5"},
            new Ingredient() { Id = 6, IngredientName = "ESB Hops"},
            new Ingredient() { Id = 7, IngredientName = "High Plains Barley"},
            new Ingredient() { Id = 8, IngredientName = "Rocky Mountain Spring-Water"},
        };

        // GET: api/Ingredient
        [Route("")]
        public IEnumerable<Ingredient> Get()
        {
            return Ingredients;
        }

        [Route("{name}")]
        [HttpGet]
        public IEnumerable<Ingredient> FindIngredientByName(string name)
        {
            Ingredient[] IngredientArray = Ingredients.Where<Ingredient>(c => c.IngredientName.Contains(name)).ToArray<Ingredient>();

            return IngredientArray;
        }
    }
}




