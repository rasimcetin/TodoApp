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
                .OrderBy(x => x.Title)
                .Select(x => new TodoDto(x.Id, x.Title, x.IsCompleted, x.UntilDate))
                .ToListAsync(); 
                
    }

    public Task<TodoDto?> GetByIdAsync(Guid id)
    {
        return dbContext.Todos.Where(x => x.Id == id)
                              .Select(t => new TodoDto(t.Id, t.Title, t.IsCompleted, t.UntilDate))
                              .FirstOrDefaultAsync();
    }

    public Task<Todo?> GetTodoEntityByIdAsync(Guid id)
    {
        return dbContext.Todos.Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public Task UpdateAsync(Todo todo)
    {
        dbContext.Todos.Update(todo);
        return dbContext.SaveChangesAsync();
    }
    
}
