using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
     {
            Console.WriteLine("Enter  First Name");
            var data = Console.ReadLine();

            string pattern = "^[A-Z]{1}[a-z]{2,}$";

            Regex regex = new Regex(pattern);

            if(regex.IsMatch(data))
        {
            Console.WriteLine("Is valid First Name");
        }
            else
        {
            Console.WriteLine("Invalid");
        }
    }
}
    