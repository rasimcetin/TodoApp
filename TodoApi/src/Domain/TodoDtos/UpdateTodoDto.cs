namespace TodoDtos;

public record UpdateTodoDto
{
    public Guid Id { get; init; }
    public bool IsCompleted { get; init; }
    public string Description { get; init; } = string.Empty;
    public DateTimeOffset UntilDate { get; init; }
}
