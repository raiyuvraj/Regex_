using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
     {
            Console.WriteLine("Enter  Passowrd :");
            var data = Console.ReadLine();

        string pattern = "^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$";
            Regex regex = new Regex(pattern);

            if(regex.IsMatch(data))
        {
            Console.WriteLine("Is valid Password");
        }
            else
        {
            Console.WriteLine("Invalid");
        }
    }
}
    