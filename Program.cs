using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Plan Your Heist!");

        //store team members
        List<TeamMember> teamMembers = new List<TeamMember>();

        while (true)
        {

        Console.Write("Enter team member's name (or leave blank to finish): ");
        string name = Console.ReadLine();

        // if entered name is empty exit the loop
        if (string.IsNullOrWhiteSpace(name))
        break;

        Console.Write("Enter team member's skill level: ");
        int skillLevel = int.Parse(Console.ReadLine());

        Console.Write("Enter team member's courage factor (0.0-2.0): ");
        double courageFactor = double.Parse(Console.ReadLine());

        // create a new team member object with info
       TeamMember member = new TeamMember(name, skillLevel, courageFactor);

       // add new member to teamMembers list
       teamMembers.Add(member);
       Console.WriteLine();
    }

    Console.WriteLine($"Number of team members: {teamMembers.Count}");

    Console.WriteLine("Team Members: ");

    // go through each member and print their details
    foreach (var member in teamMembers)
    {
        Console.WriteLine($"Name: {member.Name}");
        Console.WriteLine($"Skill Level: {member.SkillLevel}");
        Console.WriteLine($"Courage Factor: {member.CourageFactor}");
        Console.WriteLine();
    }
}
}

class TeamMember
{
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public double CourageFactor { get; set; }

    public TeamMember(string name, int skillLevel, double courageFactor)
    {
        Name = name;
        SkillLevel = skillLevel;
        CourageFactor = courageFactor;
    }
}

