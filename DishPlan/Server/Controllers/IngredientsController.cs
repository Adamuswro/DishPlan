using AutoMapper;
using DishPlan.Server.Data;
using DishPlan.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DishPlan.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public IngredientsController(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ingredientsEntities = await context.Ingredients
                                    .ToListAsync();

            var result = mapper.Map<IEnumerable<Ingredient>, IEnumerable<IngredientDTO>>(ingredientsEntities);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] IngredientDTO newIngredient)
        {
            context.Ingredients.Add(mapper.Map<IngredientDTO, Ingredient>(newIngredient));
            await context.SaveChangesAsync();

            return Ok(await context.Ingredients.ToListAsync());
        }
    }
}
