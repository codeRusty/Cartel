using Cartel.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using System.Threading.Tasks;

namespace Cartel.Api.Controllers
{
    [Route("[controller]")]
    public class ActivitiesController : Controller
    {
        private readonly IBusClient _busClient;

        public ActivitiesController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] CreateUser command)
        {
            await _busClient.PublishAsync(command);
            return Accepted();
        }
    }
}
