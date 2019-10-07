using System;
using System.Collections.Generic;

namespace RobbingBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");
        List<Dictionary<string, string>> team =
        new List<Dictionary<string, string>>();

        Console.Write("Bank Difficulty> ");
        int bankDifficulty = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random generator = new Random();






Console.Write("Name > ");
            string name = Console.ReadLine();

            while (name != "")

        {

            Console.Write("Skill Level> ");
            string skillLevel = Console.ReadLine();

            Console.Write("Courage Factor > ");
            string courageFactor = Console.ReadLine();

            Dictionary<string, string> member = new Dictionary<string, string>(){
                {"Name", name},
                {"SkillLevel", skillLevel},
                {"CourageFactor", courageFactor}
            };
            team.Add(member);

            Console.WriteLine();
            // Get Next Team Member Name
            Console.Write("Name > ");
            name = Console.ReadLine();
         }
            Console.WriteLine();
            Console.Write("nuber of runs>");
            int trailRunCount = int.Parse(Console.ReadLine());
            Console.WriteLine($"Team Size {team.Count}");

            int teamSkill = 0;
            foreach(Dictionary<string, string>member in team) {
                string skillLevel = member["SkillLevel"];
                teamSkill = teamSkill + int.Parse(skillLevel);
            }

            Dictionary<string, int>report = new Dictionary<string, int>() {
                {"Successes", 0},
                {"Failures", 0}
            };

        for(int i=0; i < trailRunCount; i++)
        {

             int luckValue = generator.Next(-10, 11);

            int trailRunBankDifficulty =  bankDifficulty + luckValue;

            Console.WriteLine($"Team Skill Level: {teamSkill}");
            Console.WriteLine($"Bank Difficulty: {trailRunBankDifficulty}");

        if(trailRunBankDifficulty > teamSkill){
            Console.WriteLine("Your heiest blew");
            int failures = report["Failures"];
            report["Failures"] = failures + 1;
        }else{
            Console.WriteLine("YOU DID IT!");
            int successes = report["Successes"];
             report["Successes"] = successes + 1;
        }

        }

        Console.WriteLine();
        Console.WriteLine("Heist Results");
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Success: {report["Successes"]}");
        Console.WriteLine($"Failures: {report["Failures"]}");
         Console.WriteLine();
          Console.WriteLine();
     }
    }
}
