using TodoDtos;
using TodoEntities;

namespace TodoRepositoryInterfaces;

public interface ITodoRepository
{
    Task AddAsync(Todo todo);
    Task<List<TodoDto>> GetAllAsync();
    Task<Todo?> GetByIdAsync(Guid id);
    Task UpdateAsync(Todo todo);
    Task DeleteAsync(Guid id);
}
