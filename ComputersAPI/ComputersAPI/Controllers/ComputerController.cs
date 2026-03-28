using ComputersAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputersAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComputerController : ControllerBase
    {
        private static List<ComputerModel> AllComputers = new List<ComputerModel>();

        [HttpPost]

        public IActionResult CreateComputer([FromBody] ComputerModel computer)
        {
            computer.Id = AllComputers.Count + 1;
        }

    }
}
