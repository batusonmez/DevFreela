using DevFreela.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get(string query)
        {
            return Ok();
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(GetById),new {id = createProject.Id}, createProject);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] UpdateProjectModel createProject)
        {
            if (createProject.Description.Length > 50)
            {
                return BadRequest();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id )
        {
            
            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id,[FromBody] CreateCommentModel createComment)
        {

            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
           
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult finish(int id)
        {

            return NoContent();
        }
    }
}
