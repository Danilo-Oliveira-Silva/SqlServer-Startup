using Microsoft.AspNetCore.Mvc;
using ToDo.Api.Models;
using ToDo.Api.Repository;

namespace ToDo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    protected readonly ITaskRepository _repository;

    public TaskController(ITaskRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repository.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] TodoTask todoTask)
    {
        return Created("", _repository.Add(todoTask));
    }

    [HttpPut("{id:int}")]
    public IActionResult Put(int id, [FromBody] TodoTask todoTask)
    {
        try 
        {
            return Ok(_repository.Update(id, todoTask));
        } 
        catch(Exception)
        {
            return BadRequest(new { message = "Error on request" });
        }
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        try 
        {
            _repository.Delete(id);
            return NoContent();
        } 
        catch(Exception)
        {
            return BadRequest(new { message = "Error on request" });
        }
    }
}
