using Cartel.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using System;
using System.Threading.Tasks;

namespace Cartel.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IBusClient _busClient;

        public UsersController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Post([FromBody] CreateActivity command)
        {
            command.Id = Guid.NewGuid();
            command.CreatedAt = DateTime.Now;
            await _busClient.PublishAsync(command);
            return Accepted($"activities/{command.Id}");
        }
    }
}
