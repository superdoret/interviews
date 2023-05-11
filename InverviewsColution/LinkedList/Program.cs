using System.Collections.Generic;

LinkedList<Person> entities = new();

public record Person
{
    public string? GivenName { get; set; }
    public string? FamilyName { get; set; }
}
