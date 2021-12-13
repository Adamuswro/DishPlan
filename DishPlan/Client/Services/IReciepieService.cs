using DishPlan.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DishPlan.Client.Services
{
    public interface IReciepieService
    {
        List<Reciepie> Reciepies { get; set; }

        Task GetReciepies();
    }
}