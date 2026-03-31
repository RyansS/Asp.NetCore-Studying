using System.ComponentModel.DataAnnotations;

namespace ComputersAPI.Models
{
    public class ComputerModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Your model exceeded the maximum amount of characters")]
        [MaxLength(255)]
        public string Model { get; set; }
        //**********************
        [Required(ErrorMessage = "The price is invalid")]
        [Range(100, 150000)]
        public decimal Price { get; set; }
        //**********************
        [MaxLength(30)]
        public string Os { get; set; }
        //**********************
        [MaxLength (500)]
        public string Description { get; set; }
        //**********************
        

    }
}
