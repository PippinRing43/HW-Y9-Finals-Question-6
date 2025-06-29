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
            string value = "";


            bool valid = false;
            do
            {
                Console.WriteLine("Enter a username.");
                string username = Console.ReadLine();
                Console.WriteLine("Enter a password.");
                string password = Console.ReadLine();
                if (loginDetails.ContainsKey(username))
                {
                    if (loginDetails.TryGetValue(username, out value))
                    {

                    }
                }
            } while (!valid);
        }
    }
}
