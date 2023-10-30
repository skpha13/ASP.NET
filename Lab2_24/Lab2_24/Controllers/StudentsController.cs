using Lab2_24.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab2_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ana", Age = 21},
            new Student { Id = 2, Name = "Maria", Age = 19},
            new Student { Id = 3, Name = "Vlad", Age = 22},
            new Student { Id = 4, Name = "Florin", Age = 25},
            new Student { Id = 5, Name = "Marian", Age = 20},
        };

        // endpoint 
        // Get 
        [HttpGet]
        public List<Student> Get()
        {
            return students.OrderBy(o => o.Age).ToList();
        }

        // Create

        [HttpPost]
        public List<Student> Add(Student student)
        {
            students.Add(student);
            return students;
        }


        [HttpDelete]
        public List<Student> Delete(Student student)
        {
            var studentIndex = students.FindIndex( x => x.Id == student.Id);
            students.RemoveAt(studentIndex);
            return students;
        }

        [HttpDelete("DeleteById")]
        public List<Student> DeleteById(int Id)
        {
            students.RemoveAll(Student => Student.Id == Id);
            return students;
        }

		[HttpGet("ordered")]
		public List<Student> GetOrdered()
        {

            return students.OrderBy(student => student.Name).ToList(); ;
        }

        [HttpDelete("{id}")]
        public List<Student> DeleteId(int id)
        {
            students.RemoveAll(student => student.Id == id);
            return students;
        }
    }
}
