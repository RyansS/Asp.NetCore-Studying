using System.ComponentModel.DataAnnotations;

namespace ComputersAPI.Models
{
    public class ComputerModel
    {
        [Required(ErrorMessage = "Your model exceeded the maximum amount of characters")]
        [MaxLength(255)]
        public string Model { get; private set; }
        //**********************
        [Required(ErrorMessage = "The price is invalid")]
        [Range(100, 150000)]
        public decimal Price { get; private set; }
        //**********************
        [MaxLength(30)]
        public string Os { get; private set; }
        //**********************
        [MaxLength (500)]
        public string Description { get; private set; }
        //**********************
        public int Id { get; set; }

    }
}
