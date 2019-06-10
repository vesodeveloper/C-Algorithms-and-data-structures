using System;
using System.Collections.Generic;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dct = new Dictionary<string, string>();
            Console.WriteLine("Enter count of the team:");
            var count = int.Parse(Console.ReadLine());
            Console.WriteLine("Add Elements:"); int members = 0;
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();

                string[] createTeam = input.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                string user = createTeam[0];
                string team = createTeam[1];
                if (dct.ContainsKey(createTeam[0]) == false)
                {
                    dct.Add(user, team);
                }
                Console.WriteLine("Team" + team + "has been created by" + user + "!");
                if (dct.ContainsValue(createTeam[1]))
                {
                    Console.WriteLine("Team" + team + "was already created!");
                }
                if (dct.ContainsKey(createTeam[0]))
                {
                    Console.WriteLine(user + "cannot create another team!");// 1 user - 1 team
                }
                string[] adduser = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);// user -> team
                string user1 = adduser[0];
                //string team1 = adduser[1];
                if (dct.ContainsKey(adduser[0]) == false)
                {
                    dct.Add(user1, team); members++;
                }
                if (dct.ContainsValue(createTeam[1]) == false)
                {
                    Console.WriteLine("Team" + team + "does not exist!");
                }
                if (dct.ContainsKey(adduser[0]))
                {
                    Console.WriteLine("Member" + user1 + "cannot join team" + team + "!");
                }
                if (dct.ContainsValue(createTeam[1]) == false) // user without team members=0
                {
                    foreach (var item in createTeam
                    .OrderBy(x => x.Key)
                     .ThenBy(x => x.Value)) ;

                }
                if (input == "end of assignment")
                {
                    foreach (var item in dct)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}


