using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
     {
            Console.WriteLine("Enter  Mobile No. :");
            var data = Console.ReadLine();

        string pattern = "^[+][][0-9]{1,3}[ ][6-9]{1}[0-9]{9}$";
            Regex regex = new Regex(pattern);

            if(regex.IsMatch(data))
        {
            Console.WriteLine("Is valid Mobile No.");
        }
            else
        {
            Console.WriteLine("Invalid");
        }
    }
}
    