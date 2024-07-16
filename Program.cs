
using ConsoleApp1;
using System.Text.RegularExpressions;

class Program : matches
{
    public static void Main(string[] args)
    {
        // Async and await.
        //    method1();
        //    method2();

        //    Console.ReadKey(); }

        //public static async Task method1()
        //{
        //   await  Task.Run(() => { 
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine($"This is method 1 running{i}\n");
        //            Task.Delay(200).Wait();
        //        }
        //    });
        //}

        //public static void method2()
        //{
        //    for (int i = 0;i<5; i++)
        //    {
        //        Console.WriteLine($"This is method 2 running{i}");
        //        Task.Delay(100).Wait();
        //    }

        //oops concept in c#
        //1.inhertance
        //=>single , multilevel, heirarchical, multiple.

        //addition addition = new addition();
        //  addition.Add(10, 50);
        //  Addiction Add2 = new Addiction();
        //  Add2.Add(10, 100);

        //  mathematics mathk = new mathematics();
        //  mathk.Add(10, 5);

        //  Lion simba = new Lion();
        //simba.Roar("Simba");
        //  dog champ = new dog();
        // champ.Roar();
        // adding(dict);
        // printingdict(dict);
        Player kishan = new Player();
        kishan.Kishan();

    }

}


    abstract class Animal
    {
        public void Roar()
        {
            Console.WriteLine("Animal Roared");
        }
        public void sleep()
        {
            Console.WriteLine("Slept");
        }


    }

    class Lion : Animal
    {
        public void Roar(string name)
        {
            Console.WriteLine($"{name} roared");
        }
    }

    class dog : Animal
    {
        //public void Roar(string name)
        //{
        //    Console.WriteLine($"{name} barked");
        //}
    }

    class Addition
    {
        public int num1;
        public int num2;

        public void Add(int num, int numt)
        {
            this.num1 = num;
            this.num2 = numt;
            Console.WriteLine(this.num1 + this.num2);
        }
    }
    class Addiction : Addition
    {
        public int kish;
        public void Subt(int num, int num2)
        {
            Console.WriteLine(num - num2);
        }
    }







//namespace ConsoleApp1
//{
//    internal class player
//    {
//        public static void main(string[] args)
//        {
//            List<string> players = new List<string>()
//        {
//            "Player 1", "Player 2", "Player 3", "Player 4",
//                "Player 5", "Player 6", "Player 7", "Player 8"

//        };

//            int rounds = players.Count;

//            Console.WriteLine($"Total number of players are {players.Count}");
//            Console.WriteLine($"Total number of rounds are {rounds}");

//        }
//    }
//}



