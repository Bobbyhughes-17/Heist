using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Plan Your Heist!");

        //store team members
        List<TeamMember> teamMembers = new List<TeamMember>();
        
        while (true)
        {

        Console.Write("Enter team member's name (or leave blank to finish adding members): ");
        string name = Console.ReadLine();

        // if entered name is empty exit the loop
        if (string.IsNullOrWhiteSpace(name))
        break;
        //check to see if it's only letters 
        if (Regex.IsMatch(name, "^[a-zA-Z]+$"))
        {

        }
        else
        {
            Console.WriteLine("Invalid input must be letters only yo");
            continue;
        }

        Console.Write("Enter team member's skill level: ");
        int skillLevel = int.Parse(Console.ReadLine());


        double courageFactor;
        while (true)
        {
        Console.Write("Enter team member's courage factor (0.0-2.0): ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out courageFactor))
        {
            if (courageFactor >= 0.0 && courageFactor <= 2.0)
            {
               break;
            }
        }
        Console.WriteLine("Invalid input");
        }
        // create a new team member object with info
       TeamMember member = new TeamMember(name, skillLevel, courageFactor);

       // add new member to teamMembers list
       teamMembers.Add(member);
       Console.WriteLine();
    }

    int bankDifficultyLevel = 100;
    int totalSkillLevel = 0;

    foreach (var member in teamMembers)
    {
        totalSkillLevel += member.SkillLevel;
    }

    Console.WriteLine("-- Heist Report --");
    Console.WriteLine($"Total Team Skill Level: {totalSkillLevel}");
    Console.WriteLine($"Bank Difficulty Level: {bankDifficultyLevel}");

    if (totalSkillLevel >= bankDifficultyLevel)
    {
        Console.WriteLine("Success! Skill level was enough!");
    }
    else
    {
        Console.WriteLine("Failure! Skill level was not enough!");
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

