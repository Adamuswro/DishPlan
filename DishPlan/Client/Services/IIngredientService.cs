using DishPlan.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DishPlan.Client.Services
{
    public interface IIngredientService
    {
        List<IngredientDTO> Ingredients { get; set; }

        Task GetIngredientsAsync();
    }
}