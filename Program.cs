using System;

namespace IntroductionInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            Setup();
            //Introduction
            Console.WriteLine("Beep Boop Beep!");
            Speak(3);
            Console.WriteLine("Hello Im Orbit A digital assistant that created to assist you in this Program");
            Console.WriteLine("But First! may i Know Your Name?");
            Console.ReadLine();
            Speak(3);
            Console.WriteLine("Great Name! Thankyou For Giving your name");

            //Close Program
            Console.ReadKey();
        }

        static void Setup()
        {
            Console.Title = "Rock Paper Scissor Game!";
        }

        static void Speak(int t){
            for (int i = 0; i < t; i++)
            {
                Console.Beep();
            }
        }
    }
}