using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using TodoData;
using TodoDtos;
using TodoEntities;
using TodoRepositoryInterfaces;

namespace TodoRepositories;

public class TodoRepository (TodoDbContext dbContext) : ITodoRepository
{
    public Task AddAsync(Todo todo)
    {
        dbContext.Todos.Add(todo);
        return dbContext.SaveChangesAsync();
    }

    public Task DeleteAsync(Guid id)
    {
        dbContext.Todos.Remove(new Todo { Id = id });
        return dbContext.SaveChangesAsync();
    }

    public Task<List<TodoDto>> GetAllAsync()
    {
       return dbContext.Todos
                .Select(x => new TodoDto(x.Id, x.Description, x.IsCompleted, x.UntilDate))
                .ToListAsync(); 
                
    }

    public Task<Todo?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Todo todo)
    {
        throw new NotImplementedException();
    }
}
