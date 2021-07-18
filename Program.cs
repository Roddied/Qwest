using System;
using System.IO;

namespace Qwest
{
    class Dice {
        public static int D20() {
            Random rnd = new Random();
            int d20 = rnd.Next(1, 20);
            return d20;
        }
        public static int D8() {
            Random rnd = new Random();
            int d8 = rnd.Next(1, 8);
            return d8;
        }
        public static int D10() {
            Random rnd = new Random();
            int d10 = rnd.Next(1, 10);
            return d10;
        }
    }
    class Greetings { 
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Little Mouse\nWhat is your name?");
            string Name = Console.ReadLine();
            await.Task.Delay(50);
            Console.WriteLine("Oh, hello, " + Name + ". And I'm Kaleb - your mentor for this test.");
            int d20 = Dice.D20();
            int d8 = Dice.D8();
            int d10 = Dice.D10();
            Console.WriteLine(d20 + ", " + d8 + ", " + d10);
            
            
            
        }
    }
}
