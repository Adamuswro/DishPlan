using AutoMapper;
using DishPlan.Server.Data;
using DishPlan.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DishPlan.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReciepiesController : ControllerBase
    {
        private readonly DataContext context;   
        private readonly IMapper mapper;

        public ReciepiesController(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var reciepieEntities = await context.Reciepies
                .Include(r=>r.Ingredients)
                .ThenInclude(r=>r.Ingredient)
                .ToListAsync();

            var result = mapper.Map<IEnumerable<Reciepie>, IEnumerable<ReciepieDTO>>(reciepieEntities);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ReciepieDTO newReciepie)
        {
            var ingredients = context.Ingredients.Where(i => newReciepie.Ingredients.Select(x => x.IngredientId).Contains(i.Id)).ToList();
            var newReciepieEntity = mapper.Map<ReciepieDTO, Reciepie>(newReciepie);
            var existingIngredients = newReciepieEntity.Ingredients.Where(i => i.IngredientId != 0);
            foreach (var ingredient in existingIngredients)
            {
                ingredient.Ingredient = ingredients.FirstOrDefault(i => i.Id == ingredient.IngredientId);
            }

            context.Reciepies.Add(newReciepieEntity);
            await context.SaveChangesAsync();

            return Ok(await context.Reciepies.ToListAsync());
        }
    }
}
