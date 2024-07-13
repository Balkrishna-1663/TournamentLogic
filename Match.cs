<<<<<<< HEAD
﻿using ConsoleApp1;
using System;
=======
﻿using System;
>>>>>>> d5b17ec2b4495faca2d29c158c00ecb19dffbdfb
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
<<<<<<< HEAD
    internal class Player : matches
    {
        public static void Main(string[] args)
        {
            List<string> players = new List<string>()
=======
    internal class Player:matches
    {
        public static void Main(string[] args) {
        List<string> players = new List<string>()
>>>>>>> d5b17ec2b4495faca2d29c158c00ecb19dffbdfb
        {
            "Player 1", "Player 2", "Player 3", "Player 4",
                "Player 5", "Player 6", "Player 7", "Player 8"

        };

<<<<<<< HEAD
            int rounds = players.Count - 1;
=======
        int rounds = players.Count-1;
>>>>>>> d5b17ec2b4495faca2d29c158c00ecb19dffbdfb

            Console.WriteLine($"Total number of players are {players.Count}");
            Console.WriteLine($"Total number of rounds are {rounds}");

<<<<<<< HEAD
            chuhi(players);



        }
    }

    class matches
    {
        public static async Task Pairs(List<string> Players)
        {
            for (int i = 0; i < Players.Count; i++)
            {
                Console.WriteLine("For " + (i + 1) + " player\n");
                //Task.Delay(190).Wait();

                for (int j = 0; j < Players.Count; j++)
                {
                    if (i != j)
                    {
                        Console.WriteLine($"{Players[i]} vs {Players[j]}\n");
                        //Task.Delay(200).Wait();
                    }
                }

            }
        }
        public static void chuhi(List<string> Players)
        {
            for (int round = 1; round <= Players.Count-1; round++)
            {
                Console.WriteLine($"Round {round}:");
                for (int i = 0; i < Players.Count; i += 2)
                {
                    if (i + 1 < Players.Count)
                    {
                        Console.WriteLine($"{Players[i]} vs {Players[i + 1]}");
                    }
                }
                // Rotate players except the first one
                Players = RotatePlayers(Players);
            }
        }

        static List<string> RotatePlayers(List<string> Players)
        {
            List<string> rotatedPlayers = new List<string>();
            rotatedPlayers.Add(Players[0]); // Keep the first player in the same position

            for (int i = 2; i < Players.Count; i++)
            {
                rotatedPlayers.Add(Players[i]);
            }

            rotatedPlayers.Add(Players[1]); // Move the second player to the last position
            return rotatedPlayers;
        }

    }
}



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
