using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishPlan.Shared
{
    public class ReciepieDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReciepieText { get; set; }
        [ValidateComplexType]
        public List<ReciepieIngredientDTO> Ingredients { get; set; }
        public string SourceLink { get; set; }
    }
}
