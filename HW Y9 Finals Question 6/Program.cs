using System;

namespace HW_Y9_Finals_Question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> loginDetails = new Dictionary<string, string>();
            loginDetails.Add("Yusuf5", "33kk");
            loginDetails.Add("Mary80", "af5r");

            bool valid = false;
            do
            {
                Console.WriteLine("Enter a username.");
                string username = Console.ReadLine();
                if (loginDetails.ContainsKey(username))
                {
                    Console.WriteLine("Enter a password.");
                    string password = Console.ReadLine();
                    if (loginDetails[username] == password)
                    {
                        Console.WriteLine("Access granted.");
                        valid = true;
                    } else
                    {
                        Console.WriteLine("Username and password do not match. Please try again.");
                    }
                } else
                {
                    Console.WriteLine("Username could not be found. Please try again.");
                }
                
            } while (!valid);
        }
    }
}
