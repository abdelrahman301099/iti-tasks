using System.ComponentModel.DataAnnotations.Schema;

namespace firstMVC.Models.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public decimal Salary { get; set; }
        public  string Address { get; set; }

        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        public Course  Course { get; set; }


    }
}
