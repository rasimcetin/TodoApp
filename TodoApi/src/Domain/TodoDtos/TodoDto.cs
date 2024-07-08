namespace TodoDtos;

public record TodoDto(Guid Id, string Description, bool IsCompleted, DateTimeOffset UntilDate);
