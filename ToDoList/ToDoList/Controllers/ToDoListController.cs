using Microsoft.AspNetCore.Mvc;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("api/todolist")]
    public class ToDoListController : ControllerBase
    {
        private TaskContext _context;

        public ToDoListController (TaskContext context)
        {
            _context = context;
        }

        //Create Task
        [HttpPost]

        public CreatedAtActionResult PostCreateTask ([FromBody] ToDoListModel newTask)
        {
            _context.Add(newTask);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetTaskById), new {id = newTask.Id}, newTask);
        }

        [HttpGet]

        public IActionResult GetAllTasks ()
        {
            return Ok(_context.Tasks);
        }

        [HttpGet("{id}")]

        public IActionResult GetTaskById (int id)
        {
            var TaskFound = _context.Tasks.FirstOrDefault(task => task.Id == id);
            if (TaskFound == null) return NotFound();

            return Ok(TaskFound);
        }

    }
}
