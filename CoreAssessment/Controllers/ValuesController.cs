using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
private readonly ValueDbContext Valuedbcontext;
        public ValuesController(ValueDbContext ValueDbContext)
        {
            Valuedbcontext = ValueDbContext;
        }
        [HttpGet]
        public IEnumerable<Token> GetMovies()
        {
            return Valuedbcontext.token.ToList();
        }
        [HttpGet("GetMovieById")]
        public Token GetMovieById(int Id)
        {
            return Valuedbcontext.token.Find(Id);
        }
        
[HttpPost("InsertMovie")]
public IActionResult InsertMovie([FromBody] Token token)
        {
            if (token.Id.ToString() != "")
            {
                Valuedbcontext.token.Add(token);
                Valuedbcontext.SaveChanges();
                return Ok("Movie details saved successfully");
            }
            else
                return BadRequest();
        }

        
[HttpPut("UpdateMovie")]
public IActionResult UpdateMovie([FromBody] Token token)
        {
            if (token.Id.ToString() != "")
            {
                
                Valuedbcontext.Entry(token).State = EntityState.Modified;
                Valuedbcontext.SaveChanges();
                return Ok("Updated successfully");
            }
            else
                return BadRequest();
        }


        [HttpDelete("DeleteMovie")]
        public IActionResult DeleteTutorial(int Id)
        {
            
            var result = Valuedbcontext.token.Find(Id);
            Valuedbcontext.token.Remove(result);
            Valuedbcontext.SaveChanges();
            return Ok("Deleted successfully");
        }
    }
}
