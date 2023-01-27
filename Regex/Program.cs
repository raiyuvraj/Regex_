using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
     {
            Console.WriteLine("Enter  Email Id. :");
            var data = Console.ReadLine();

        string pattern = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$";
            Regex regex = new Regex(pattern);

            if(regex.IsMatch(data))
        {
            Console.WriteLine("Is valid Email Id.");
        }
            else
        {
            Console.WriteLine("Invalid");
        }
    }
}
    