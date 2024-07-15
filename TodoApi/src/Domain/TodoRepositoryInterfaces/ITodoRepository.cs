using TodoDtos;
using TodoEntities;

namespace TodoRepositoryInterfaces;

public interface ITodoRepository
{
    Task AddAsync(Todo todo);
    Task<List<TodoDto>> GetAllAsync();
    Task<TodoDto?> GetByIdAsync(Guid id);
    Task UpdateAsync(Todo todo);
    Task DeleteAsync(Guid id);
    Task<Todo?> GetTodoEntityByIdAsync(Guid id);
}
