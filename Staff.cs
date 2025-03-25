// Staff.cs
public class Staff : Person
{
    public string Position { get; set; }
    public string Department { get; set; }
    public string Nickname { get; set; } // Random detail ra!

    public Staff(string name, string email, string id, string position, string department, string nickname = "")
        : base(name, email, id)
    {
        Position = position;
        Department = department;
        Nickname = nickname;
    }

    public override string ToString()
    {
        if (!string.IsNullOrEmpty(Nickname))
            return $"Name: {Name}, ID: {ID}, Nickname: {Nickname}";
        return $"Name: {Name}, ID: {ID}";
    }
}