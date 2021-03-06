using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishPlan.Shared
{
    public class ReciepieIngredientDTO
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        [ValidateComplexType]
        public IngredientDTO Ingredient { get; set; }
        public int ReciepieId { get; set; }
        [ValidateComplexType]
        public AmountType AmountType { get; set; } = AmountType.Piece;
        public double Amount { get; set; }

        public override string ToString()
        {
            return $"{Ingredient.Name} x {Amount} {AmountType}";
        }
    }
    public enum AmountType
    {
        dag,
        kg,
        ml,
        l,
        Spoon,
        Pinch,
        Piece,
        Slice,
        Plaster
    }
}
