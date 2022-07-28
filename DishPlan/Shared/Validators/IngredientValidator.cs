using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DishPlan.Shared.Validators
{
    public class IngredientValidator : AbstractValidator<IngredientDTO>
    {
        private readonly HttpClient http;

        public IngredientValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MustAsync(async (value, cancellationToken) => await IsUniqueAsync(value));
        }

        private async Task<bool> IsUniqueAsync(string value)
        {
            return await http.GetFromJsonAsync<bool>(@$"api/ingredients/isUnique/{value}");
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<IngredientDTO>.CreateWithOptions((IngredientDTO)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}
