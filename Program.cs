using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 0;
            string upperCase = "";
            string lowerCase = "";
            string digits = "";
            string specialChars = "";
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            int score = 0; 
            if(password.Length >= minLength)
            {
                score++;
            }

            if(Tools.Contains(password, upperCase))
            {
                score++;
            }

            if (Tools.Contains(password, lowerCase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }

            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

           Console.WriteLine(score);
        }
    }
}
