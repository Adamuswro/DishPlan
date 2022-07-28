using Bunit;
using DishPlan.Client;
using DishPlan.Client.Pages;
using DishPlan.Client.Services;
using DishPlan.Server;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace DishPlan.Tests
{
    public class IndexTests
    {
        private Bunit.TestContext testContext;
        private Mock<IReciepieService> reciepieService;

        [SetUp]
        public void Setup()
        {
            testContext = new Bunit.TestContext();
            reciepieService = new Mock<IReciepieService>();
            reciepieService.Setup(x => x.GetReciepiesAsync()).Returns(() =>
                new List<Reciepie>()
                {
                    new Reciepie()
                    {
                        Id = 1,
                        Name = "First one"
                    },
                    new Reciepie()
                    {
                        Id = 2,
                        Name = "Second"
                    }
                });

        }

        [Test]
        public void IndexPageContainsApplicationName()
        {
            testContext.Services.AddScoped(x => reciepieService.Object);
            IRenderedComponent<Index>? result = testContext.RenderComponent<Index>();

            result.CompareTo("<h1>Dish Plan</h1>");
        }
    }
}