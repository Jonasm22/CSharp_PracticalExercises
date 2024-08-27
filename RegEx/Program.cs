using System.Text.RegularExpressions;
using System;
namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //string pattern = @"\d{5}";
            string pattern = @"there";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12314";
            
            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine($"hit found: {matchCollection.Count} \n {text} ");

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"Fount at {group[0].Value} , {group[0].Index}");


            }
        }
    }
}
