//multiplication practice Made by Kaden (Second ever c# project).
using System;
using System.Text;
namespace multiples
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            run();
            Console.ReadKey();
            static void run()
            {
                Console.OutputEncoding = Encoding.UTF8;
                int correct = 1;
                int incorrect = 1;
                Console.WriteLine("What is the max multiple you would like? ");
                int Maximum = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < 100; i = i++)
                {
                    Random rnd = new Random();
                    int first = rnd.Next(0, Maximum);
                    int second = rnd.Next(0, Maximum);
                    Console.WriteLine(first + "x" + second + "= ?");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == first * second)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        int Tcorrect = correct++;
                        int Tincorrect = incorrect;
                        Console.Clear();
                        Console.WriteLine($"{answer} ✅");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Good Job!");
                        Console.WriteLine($"Correctly solved ✅ = {Tcorrect}");
                        Console.WriteLine($"Incorrect solved ❌ = {Tincorrect}");
                    }
                    if (answer != first * second)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        int Tincorrect = incorrect++;
                        int Tcorrect = correct;
                        Console.Clear();
                        Console.WriteLine($"{answer} ❌");
                        Console.WriteLine("Not quite...");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Correctly solved ✅ = {Tcorrect}");
                        Console.WriteLine($"Incorrect solved ❌ = {Tincorrect}");
                    }
                }
            }
        }
    }
}