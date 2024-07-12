using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player:matches
    {
        public static void Main(string[] args) {
        List<string> players = new List<string>()
        {
            "Player 1", "Player 2", "Player 3", "Player 4",
                "Player 5", "Player 6", "Player 7", "Player 8"

        };

        int rounds = players.Count-1;

            Console.WriteLine($"Total number of players are {players.Count}");
            Console.WriteLine($"Total number of rounds are {rounds}");

            Pairs(players);
            

       }     
    }

    class matches 
    {
        public static void Pairs(List<string> Players)
        {
            for (int i = 0; i < Players.Count; i++)
            {

                Console.WriteLine(Players[i]);

            }
        }
    }

}
