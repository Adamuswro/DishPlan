using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishPlan.Shared
{
    public class Reciepie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReciepieText { get; set; }
        public List<ReciepieIngredient> Ingredients { get; set; }
    }
}
