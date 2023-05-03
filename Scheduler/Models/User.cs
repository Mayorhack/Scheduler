using System.ComponentModel.DataAnnotations;

namespace Scheduler.Models
{
    public class User
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="This field is required")]
        public string Name { get; set; }

        public string Email { get; set; }

       
    }
}
