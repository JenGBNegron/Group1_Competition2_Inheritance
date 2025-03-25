using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Staff> staffList = new List<Staff>
        {
            new Staff("Grandon Gill", "grandon@university.edu", "S001", "Professor", "Information Systems", "Book Boss"),
            new Staff("Amara Singh", "amara@uni.edu", "S002", "Librarian", "Library Services", "Silent Hawk"),
            new Staff("Carlos Mendes", "carlos@uni.edu", "S003", "IT Technician", "Tech Support", "Wire Wizard"),
            new Staff("Sofia Chen", "sofia@uni.edu", "S004", "Research Analyst", "Data Science", "Chart Queen"),
            new Staff("Leo Patel", "leo@uni.edu", "S005", "Assistant Professor", "Computer Science", "Code Ninja"),
            new Staff("Nina Varga", "nina@uni.edu", "S006", "HR Manager", "Human Resources", "People Power"),
            new Staff("David Osei", "david@uni.edu", "S007", "Security Officer", "Campus Safety", "Night Panther"),
            new Staff("Mei Tanaka", "mei@uni.edu", "S008", "Finance Officer", "Accounting", "Money Maestro"),
            new Staff("Arjun Rao", "arjun@uni.edu", "S009", "Lab Assistant", "Physics Lab", "Particle Prince"),
            new Staff("Layla Johnson", "layla@uni.edu", "S010", "Events Coordinator", "Student Affairs", "Vibe Queen")
        };

        foreach (var staff in staffList)
        {
            Console.WriteLine(staff.ToString());
        }
    }
}
