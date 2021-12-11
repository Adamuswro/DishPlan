using DishPlan.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DishPlan.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReciepiesController : ControllerBase
    {
        private readonly DataContext context;

        public ReciepiesController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var reciepies = await context.Reciepies
                .Include(r=>r.Ingredients)
                .ThenInclude(r=>r.Ingredient)
                .ToListAsync();

            return Ok(reciepies);
        }
    }
}
