﻿using System;
using System.Threading;

namespace Stopwatch;

class Program
{
    static void Main(string[] args)
    {
       
       Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("1. Start in seconds");
        Console.WriteLine("2. Start in minutes");
        Console.WriteLine("3. Exit");
        Console.WriteLine("Enter the amount of time you want to start the stopwatch in: ");
        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;

        if(type == 'm')
        {
            multiplier = 60;
        }

        if(time == 0)
        {
            Console.WriteLine("Time cannot be 0");
            Thread.Sleep(2000);
            System.Environment.Exit(0);
        }

        PreStart(time * multiplier);
        // Console.Write("Enter your choice: ");
        
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go...");
        Thread.Sleep(2000);

        Start(time);
    }

    static void Start(int time)
    {       
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine("Time: " + currentTime);            
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Stopwatch has ended");
        Thread.Sleep(2000);
        Menu();
            
    }
}
