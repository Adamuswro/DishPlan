using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishPlan.Server
{
    public class Reciepie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ReciepieText { get; set; }
        public List<ReciepieIngredient> Ingredients { get; set; }
        public string SourceLink { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
