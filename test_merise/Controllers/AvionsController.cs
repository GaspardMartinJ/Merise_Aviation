using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test_merise.data;
using test_merise.models;

namespace test_merise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvionsController : ControllerBase
    {
        private readonly VoyageDbContext context;

        public AvionsController(VoyageDbContext context)
        {
            this.context = context;
        }

        /*[HttpGet]
        public List<Avion> Get()
        {
            return context.Avions.ToList();
        }*/
    }
}
