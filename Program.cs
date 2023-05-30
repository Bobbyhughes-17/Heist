using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Plan Your Heist!");

        TeamMember teamMember = new TeamMember();

        Console.Write("Enter team member's name: ");
        teamMember.Name = Console.ReadLine();

        Console.Write("Enter team member's skill level: ");
        teamMember.SkillLevel = int.Parse(Console.ReadLine());

        Console.Write("Enter team member's courage factor: ");
        teamMember.CourageFactor = double.Parse(Console.ReadLine());

        Console.WriteLine("\nTeam Member Information:");
        Console.WriteLine($"Name: {teamMember.Name}");
        Console.WriteLine($"Skill Level: {teamMember.SkillLevel}");
        Console.WriteLine($"Courage Factor: {teamMember.CourageFactor}");
    }
}

class TeamMember
{
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public double CourageFactor { get; set; }
}
