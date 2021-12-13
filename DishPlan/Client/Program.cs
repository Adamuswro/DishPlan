using Blazored.Toast;
using Blazored.Modal;
using DishPlan.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using MudBlazor.Services;

namespace DishPlan.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddBlazoredToast();
            builder.Services.AddBlazoredModal();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IReciepieService, ReciepieService>();
            builder.Services.AddMudServices();
            await builder.Build().RunAsync();
        }
    }
}
