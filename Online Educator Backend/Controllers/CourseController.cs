using Microsoft.AspNetCore.Mvc;
using Online_Educator_Backend.Data.Repositorys;
using Online_Educator_Backend.Model;
using System.Text.Json;

namespace Online_Educator_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            Console.WriteLine("TTT");
            var courses = await _courseRepository.GetAllAsync();
            Console.Write("TTTT"+courses.ToString());
            return Ok(JsonSerializer.Serialize(courses));
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            var course = await _courseRepository.GetByIdAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            return Ok(JsonSerializer.Serialize(course));
        }

        // POST: api/Courses
        [HttpPost]
        public async Task<ActionResult<Course>> PostCourse(Course course)
        {
            await _courseRepository.CreateAsync(course);
            return CreatedAtAction("GetCourse", new { id = course.Id }, course);
        }

        // PUT: api/Courses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(int id, Course course)
        {
            if (id != course.Id)
            {
                return BadRequest();
            }

            await _courseRepository.UpdateAsync(course);

            return NoContent();
        }

        // DELETE: api/Courses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {

            await _courseRepository.DeleteAsync(id);

            return NoContent();
        }
    }
}
