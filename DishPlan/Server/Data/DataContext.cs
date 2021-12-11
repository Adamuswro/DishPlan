using DishPlan.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DishPlan.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Reciepie> Reciepies { get; set; }
        public DbSet<ReciepieIngredient> ReciepieIngredients { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

    }
}
