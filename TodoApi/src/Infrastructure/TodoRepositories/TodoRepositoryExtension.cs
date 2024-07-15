
using Microsoft.Extensions.DependencyInjection;
using TodoRepositories;
using TodoRepositoryInterfaces;

public static class TodoRepositoryExtension
{
    public static void AddTodoRepository(this IServiceCollection services)
    {
        services.AddScoped<ITodoRepository, TodoRepository>();
    }
}