using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoListController : ControllerBase
    {
        private static List<ToDoListModel> Tasks = new List<ToDoListModel>();
        private static int id = 0;

        //Create Task
        [HttpPost]

        public CreatedAtActionResult PostCreateTask ([FromBody] ToDoListModel newTask)
        {
            newTask.Id = id++;
            Tasks.Add(newTask);

            return CreatedAtAction(nameof(GetTaskById), new {id = newTask.Id}, newTask);
        }

        [HttpGet]

        public IActionResult GetAllTasks ()
        {
            return Ok(Tasks);
        }

        [HttpGet("{id}")]

        public IActionResult GetTaskById (int id)
        {
            var TaskFound = Tasks.FirstOrDefault(task => task.Id == id);
            if (TaskFound == null) return NotFound();

            return Ok(TaskFound);
        }

    }
}
