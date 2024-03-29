﻿using DishPlan.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DishPlan.Client.Services
{
    public class ReciepieService : IReciepieService
    {
        private readonly HttpClient http;
        public List<ReciepieDTO> Reciepies { get; set; } = new();
        public ReciepieService(HttpClient http)
        {
            this.http = http;
        }

        public async Task GetReciepiesAsync()
        {
            Reciepies = await http.GetFromJsonAsync<List<ReciepieDTO>>("api/reciepies");
        }
    }
}
