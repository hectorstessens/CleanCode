using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;

using Microsoft.AspNetCore.Mvc;

using CleanCode.Services.Queries;
using System.Threading.Tasks;

namespace CleanCode.Controllers
{
    [Route("api/[controller]")]
    public class QuoteController : Controller
    {
        private readonly IMediator mediator;
        public QuoteController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<Plan> GetPlans()
        {

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Plan
            {
                Name = "Plan 1",
                Franchise = rng.Next(-20, 55),
                Coverage = Summaries[rng.Next(Summaries.Length)]
            });
        }

        [HttpGet]
        public async Task<QuoteResponse> Quote()
        {
            var quoteQuery = new QuoteQuery();
            return await mediator.Send(quoteQuery);
        }

        public class Plan
        {
            public string Name { get; set; }
            public int Franchise { get; set; }
            public string Coverage { get; set; }

            public decimal Price
            {
                get {
                    return 32 + (int)(2 / 0.5556);
                }
            }
        }

    }
}
