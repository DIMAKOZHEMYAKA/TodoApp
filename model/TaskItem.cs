using System;
using System.Dynamic;
public class TaskItem(int id, string title, string description)
{
    public int Id { get; } = id;
    public string Title { get; } = title;
    public string Description { get; } = description;
    public bool IsCompleted { get; set; } = false;
    public DateTime CreatedAt { get; } = DateTime.Now;

    // Methods

    public override string ToString() => $"{Id} {Title} - {Description} VseGuchi? ({(IsCompleted ? "Da" : "Net")})";

}

