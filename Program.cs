﻿using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Plan Your Heist!");

        //store team members
        List<TeamMember> teamMembers = new List<TeamMember>();
        
        Console.WriteLine("Enter Bank Difficulty: ");
    int userDifficulty = int.Parse(Console.ReadLine());
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

    Console.WriteLine("Enter amount of trial runs: ");
    int numOfTrialRuns = int.Parse(Console.ReadLine());

    


    int successfulRuns = 0;
    int failedRuns = 0;

    

    for (int i = 1; i <= numOfTrialRuns; i++)
    {
        Console.WriteLine($"-- Trial Run {i} --");
    int totalSkillLevel = 0;


    foreach (var member in teamMembers)
    {
        totalSkillLevel += member.SkillLevel;
    }

    Random random = new Random();
    int luckValue = random.Next(-10, 10);

    int addedDifficulty = userDifficulty + luckValue;

    Console.WriteLine("-- Heist Report --");
    Console.WriteLine($"Total Team Skill Level: {totalSkillLevel}");
    Console.WriteLine($"Bank Difficulty Level: {addedDifficulty}");

    if (totalSkillLevel >= addedDifficulty)
    {
        Console.WriteLine("Success! Skill level was enough!");
            successfulRuns++;

    }
    else
    {
        Console.WriteLine("Failure! Skill level was not enough!");
            failedRuns++;
    }
    Console.WriteLine();
    }
    Console.WriteLine($"Successful Runs: {successfulRuns}");
    Console.WriteLine($"Failed Runs: {failedRuns}");

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

