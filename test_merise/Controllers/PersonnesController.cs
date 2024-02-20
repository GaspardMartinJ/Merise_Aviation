using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test_merise.data;
using test_merise.models;

namespace test_merise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnesController : ControllerBase
    {
        private readonly VoyageDbContext context;

        public PersonnesController(VoyageDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public List<Personne> Get()
        {
            return context.Personnes.ToList();
        }
    }
}
