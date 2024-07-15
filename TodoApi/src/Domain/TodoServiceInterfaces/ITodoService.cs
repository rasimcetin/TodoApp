using TodoDtos;

namespace TodoServiceInterfaces;

public interface ITodoService
{
    Task<List<TodoDto>> GetAllAsync();
    Task<TodoDto?> GetByIdAsync(Guid id);
    Task AddAsync(NewTodoDto newTodoDto);
    Task UpdateAsync(UpdateTodoDto updateTodoDto);
    Task DeleteAsync(Guid id);
}
