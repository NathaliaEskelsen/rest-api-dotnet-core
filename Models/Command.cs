using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace Commander.Models
{

    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}