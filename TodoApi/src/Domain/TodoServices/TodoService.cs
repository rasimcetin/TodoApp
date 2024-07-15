using TodoDtos;
using TodoEntities;
using TodoRepositoryInterfaces;
using TodoServiceInterfaces;

namespace TodoServices;

public class TodoService : ITodoService
{
    private readonly ITodoRepository todoRepository;

    public TodoService(ITodoRepository todoRepository)
    {
        this.todoRepository = todoRepository;
    }

    public Task AddAsync(NewTodoDto newTodo)
    {
        var todo = new Todo
        {
            Id = Guid.NewGuid(),
            Description = newTodo.Description,
            IsCompleted = false,
            UntilDate = newTodo.UntilDate,
        };
        
        todoRepository.AddAsync(todo);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Guid id)
    {
        todoRepository.DeleteAsync(id);
        return Task.CompletedTask;
    }

    public Task<List<TodoDto>> GetAllAsync()
    {
        return todoRepository.GetAllAsync();
    }

    public Task<TodoDto?> GetByIdAsync(Guid id)
    {
        return todoRepository.GetByIdAsync(id);
    }

    public Task UpdateAsync(UpdateTodoDto todoDto)
    {
        var todoEntity = todoRepository.GetTodoEntityByIdAsync(todoDto.Id).Result;
        if (todoEntity == null)
        {
            return Task.CompletedTask;
        }

        todoEntity.Description = todoDto.Description;
        todoEntity.IsCompleted = todoDto.IsCompleted;
        todoEntity.UntilDate = todoDto.UntilDate;
        todoRepository.UpdateAsync(todoEntity);
        return Task.CompletedTask;
    }
}
