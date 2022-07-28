using NUnit.Framework;
using DishPlan.Client;
using Bunit;
using DishPlan.Client.Pages;

namespace DishPlan.Tests
{
    public class ReciepiesTests
    {
        private Bunit.TestContext ctx;

        [SetUp]
        public void Setup()
        {
            ctx = new Bunit.TestContext();
        }

        [Test]
        public void IndexPageContainsApplicationName()
        {
            var result = ctx.RenderComponent<Index>();

            result.CompareTo("<h1>Dish Plan</h1>");
        }
    }
}