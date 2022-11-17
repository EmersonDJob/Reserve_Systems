using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teste_Reserve_Systems.Models;

namespace Teste_Reserve_Systems.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {

        string URL = "https://documenter.getpostman.com/view/10808728/SzS8rjbc#00030720-fae3-4c72-8aea-ad01ba17adf8";

        private static readonly HttpClient HttpClient = new HttpClient();
        [HttpGet()]

        public async Task<ActionResult<Paises>> GetPaises(string url)
        {
            var client = new HttpClient();
            var result = await client.GetAsync(URL);

            if (result.IsSuccessStatusCode)
            {

                return Ok(result);
            }

            return NotFound();
        }
        
    }
}
