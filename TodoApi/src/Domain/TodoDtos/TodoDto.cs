namespace TodoDtos;

public record TodoDto(Guid Id, string Title, bool IsCompleted, DateTimeOffset UntilDate);
