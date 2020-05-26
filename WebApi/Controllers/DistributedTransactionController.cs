using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DistributedTransactionController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var httpClient = new HttpClient();
            var message = new HttpRequestMessage
            {
                RequestUri = new Uri("https://google.com"),
                Method = HttpMethod.Get,
                Version = new Version(2, 0)
            };

            var response = await httpClient.SendAsync(message);
            response.EnsureSuccessStatusCode();

            return Ok();
        }
    }
}
