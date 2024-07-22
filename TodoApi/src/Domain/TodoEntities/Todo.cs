namespace TodoEntities;

public class Todo
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = "";
    public bool IsCompleted { get; set; } = false;  

    public DateTimeOffset UntilDate { get; set; }

}
