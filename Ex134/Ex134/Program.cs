﻿using System;

namespace Ex134
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day of the week: ");//2. Prompt the user to enter the current day of the week.
            string response = Console.ReadLine();

            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), response);
            int day1 = (int)day;
    
            Console.WriteLine(response + " " + day + " " + day1);
            Console.ReadLine();
        }
    }
}
