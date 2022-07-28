using DishPlan.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DishPlan.Client.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly HttpClient http;

        public List<IngredientDTO> Ingredients { get; set; } = new();
        public IngredientService(HttpClient httpClient)
        {
            this.http = httpClient;
        }
        public async Task GetIngredientsAsync()
        {
            Ingredients = await http.GetFromJsonAsync<List<IngredientDTO>>("api/ingredients");
        }
        public async Task<bool> CreateIngredientAsync(IngredientDTO ingredientDTO)
        {
            await http.PostAsJsonAsync("api/ingredients/create", ingredientDTO);
        }
    }
}
