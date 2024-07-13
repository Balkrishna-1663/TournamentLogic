using ConsoleApp1;
using System;

﻿using System;
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

            int rounds = players.Count - 1;
       

            Console.WriteLine($"Total number of players are {players.Count}");
            Console.WriteLine($"Total number of rounds are {rounds}");

            Pairs(players);



        }
    }

    class matches
    {
        public static void Pairs(List<string> Players)
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
