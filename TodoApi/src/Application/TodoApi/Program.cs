using TodoData;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.

    var connectionString = builder.Configuration.GetConnectionString("TodoDb");

    if (!string.IsNullOrEmpty(connectionString))  
    {
        builder.Services.AddTodoData(connectionString);
    }

    builder.Services.AddTodoRepository();
    builder.Services.AddTodoService();
    builder.Services.AddCors(c => {
        c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
    });

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}



var app = builder.Build();
{
// Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseCors("AllowOrigin");
    app.UseHttpsRedirection();

    app.UseAuthorization();
    app.MapControllers();
}
app.Run();
