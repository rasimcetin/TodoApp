namespace TodoEntities;

public class Todo
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Description { get; set; } = "";
    public bool IsCompleted { get; set; } = false;  

    public DateTimeOffset UntilDate { get; set; }

}
