using System.ComponentModel.DataAnnotations.Schema;

namespace firstMVC.Models.Entities
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Address { get; set; }
        public decimal Grade { get; set; }

        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public Department Department { get; set; }

    }
}
