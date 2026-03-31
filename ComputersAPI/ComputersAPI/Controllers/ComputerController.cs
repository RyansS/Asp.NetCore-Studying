using ComputersAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ComputersAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComputerController : ControllerBase
    {
        private static List<ComputerModel> AllComputers = new List<ComputerModel>();
        private static int Id = 0;

        [HttpPost]

        public CreatedAtActionResult CreateComputer([FromBody] ComputerModel newcomputer)
        {
            newcomputer.Id = Id++;
            AllComputers.Add(newcomputer);

            return CreatedAtAction(nameof(GetComputerById), new {id = newcomputer.Id}, newcomputer);
        }

        [HttpGet]
        public List<ComputerModel> GetAllComputers()
        {
            return AllComputers;
        }

        [HttpGet("{id}")]

        public IActionResult GetComputerById (int id)
        {
            var Computer = AllComputers.FirstOrDefault(computer => computer.Id == id);
            if (Computer == null) return NotFound();

            return Ok(Computer);
        }

    }
}
