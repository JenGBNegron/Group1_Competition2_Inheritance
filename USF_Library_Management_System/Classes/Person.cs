using System.Diagnostics.Tracing;

namespace Classes
{
   public class Person
{
    // Backing fields
    private string name;
    private string email;
    private string id;

    // Properties with getters and setters
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    // Constructor
    public Person(string name, string email, string id)
    {
        this.name = name;
        this.email = email;
        this.id = id;
    }

    // Optional: Override ToString for easy display
    public override string ToString()
    {
        return $"Name: {Name}, Email: {Email}";

    }
}
}