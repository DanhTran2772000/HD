using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HD.Models;

namespace HD.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
                
        public string Name { get; set; }

        public int IdeasS { get; set; }

        public Department()
        { }
    }
}
