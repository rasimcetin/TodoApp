namespace TodoDtos;

public record NewTodoDto
{
    public string Title { get; init; } = string.Empty;
    public DateTimeOffset UntilDate { get; init; }
}
