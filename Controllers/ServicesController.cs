using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceMate.API.Data;
using ServiceMate.API.Models.Domain;

namespace ServiceMate.API.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController: ControllerBase {
        private readonly ServiceDbContext dbContext;

        public ServicesController(ServiceDbContext dbContext) {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllServices() {
            var services = dbContext.Services.ToList();

            return Ok(services);
        }

        [HttpGet("abc")]
        public async Task<IActionResult> Post() {
            var newEntity = new Service();
            newEntity.Name = "Some name";

            dbContext.Services.Add(newEntity);
            dbContext.SaveChanges();

            return Ok("Ok");
        }
    }
}