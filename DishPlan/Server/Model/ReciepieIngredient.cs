using DishPlan.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishPlan.Server
{
    public class ReciepieIngredient
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int ReciepieId { get; set; }
        public Reciepie Reciepie { get; set; }
        public AmountType AmountType { get; set; }
        public double Amount { get; set; }
    }
}
