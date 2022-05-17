using Microsoft.AspNetCore.Mvc;
using School.Data.Data;
using School.Data.Model;

namespace School.API.Controllers
{
    //localhost:<porta>/api/student
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Student> students;

        public StudentController()
        {
            students = Database.Instance().GetStudents();
        }

        [HttpGet]
        public ActionResult Ping()
        {
            return Ok("Working...");
        }
        
        [HttpGet("get-all")]
        public ActionResult GetAll()
        {
            return Ok(students);
        }

        //localhost:<porta>/api/student/id/<codigo>
        [HttpGet("id/{guid}")]
        public ActionResult GetById(string guid)
        {
            Student student = FindStudent(guid);
            return Ok(student);
        }

        [HttpPost]
        public ActionResult Post([FromBody]Student student)
        {
            if (string.IsNullOrEmpty(student.Name))
                return NoContent();

            student.Id = Guid.NewGuid();
            students.Add(student);
            return Ok(student);
        }

        [HttpPut]
        public ActionResult Put([FromBody]Student studentToEdit)
        {
            Student student = FindStudent(studentToEdit.Id.ToString());

            if (student == null) return NoContent();

            student.SetName(studentToEdit.Name);

            return Ok(student);
        }

        [HttpDelete("{code}")]
        public ActionResult Delete(string code)
        {
            Student student = FindStudent(code);
            if (student == null) return NoContent();
            students.Remove(student);

            return Ok("Student removed!");
        }

        private Student FindStudent(string guid)
        {
            return students.Find(s => s.Id.ToString() == guid);
        }
    }
}
