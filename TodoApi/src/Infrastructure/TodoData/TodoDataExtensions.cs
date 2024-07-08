using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TodoData;

public static class TodoDataExtensions
{
    public static void AddTodoData(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<TodoDbContext>(option => option.UseNpgsql(connectionString));
    }
}