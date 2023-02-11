using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace CollectionsAssignment
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, string> ClubAndPlayers = new SortedDictionary<string, string>();

            ClubAndPlayers.Add("PSG", "Neymar");
            ClubAndPlayers.Add("Liverpool", "Salah");
            ClubAndPlayers.Add("ManchesterCity", "De Bruyne");
            ClubAndPlayers.Add("ManchesterUnited", "Varane");
            ClubAndPlayers.Add("Arsenal", "Odegaard");
            ClubAndPlayers.Add("Chelsea", "Sterling");

            ClubAndPlayers.Remove("Chelsea");
            ClubAndPlayers["PSG"] = "Messi";

            Console.WriteLine($"\n{ClubAndPlayers.ContainsKey("PSG")}");

            Console.WriteLine("\nDictionary ordered by key:");
            foreach (var pair in ClubAndPlayers)
            {
                Console.WriteLine($"{pair.Key.PadRight(17, ' ')} -->  {pair.Value}");
            }

            var ReverseOrder = ClubAndPlayers.OrderByDescending(club => club.Key);

            Console.WriteLine("\nDictionary reverse order:");
            foreach (var pair in ReverseOrder)
            {
                Console.WriteLine($"{pair.Key.PadRight(17, ' ')} -->  {pair.Value}");
            }

        }
    }
}





