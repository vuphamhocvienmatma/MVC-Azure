using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Azure.Data.Model
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(50)]
        public string? Address { get; set; }
        public DateTime? DOB { get; set; }
    }
}
