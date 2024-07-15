using Microsoft.AspNetCore.Mvc;
using TodoDtos;
using TodoServiceInterfaces;

namespace TodoApi;

[ApiController]
[Route("api/[controller]")]
public class TodosController:ControllerBase
{
    ITodoService todoService;

    public TodosController(ITodoService todoService)
    {
        this.todoService = todoService;
    }

    [HttpGet()]
    public async Task<ActionResult<IEnumerable<TodoDto>>> GetAll()
    {
        return await todoService.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TodoDto?>> GetById(Guid id){

        if (id == Guid.Empty)
        {
            return BadRequest();
        }

        var todo = await todoService.GetByIdAsync(id);
        if (todo == null){
            return NotFound();
        }

        return Ok(todo);
    }

    [HttpPost]
    public async Task<IActionResult> Add(NewTodoDto newTodoDto)
    {
        try
        {
            await todoService.AddAsync(newTodoDto);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(UpdateTodoDto updateTodoDto)
    {
        try
        {
            await todoService.UpdateAsync(updateTodoDto);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var todo = await todoService.GetByIdAsync(id);
        if (todo == null)
        {
            return NotFound();
        }

        try
        {
            await todoService.DeleteAsync(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}
