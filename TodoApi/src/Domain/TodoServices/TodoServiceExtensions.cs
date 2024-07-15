using Microsoft.Extensions.DependencyInjection;
using TodoServiceInterfaces;
using TodoServices;

public static class TodoServiceExtensions
{
    public static void AddTodoService(this IServiceCollection services)
    {
        services.AddScoped<ITodoService, TodoService>();
    }
}