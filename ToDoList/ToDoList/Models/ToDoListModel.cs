using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDoListModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string TaskDescription { get; set; }

        [MaxLength(25)]
        public string TaskType { get; set; }

        [Required]
        public string TaskStatus { get; set; }


    }
}
