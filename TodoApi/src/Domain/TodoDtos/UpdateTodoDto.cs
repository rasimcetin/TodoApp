namespace TodoDtos;

public record UpdateTodoDto
{
    public Guid Id { get; init; }
    public bool IsCompleted { get; init; }
    public string Title { get; init; } = string.Empty;
    public DateTimeOffset UntilDate { get; init; }
}
