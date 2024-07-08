namespace TodoDtos;

public record NewTodoDto
{
    public string Description { get; init; } = string.Empty;
    public DateTimeOffset UntilDate { get; init; }
}
