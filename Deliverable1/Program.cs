using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please create your password. Your password must contain 7-12 characters, 1 uppercase letter, 1 lowercase letter, and 1 '!' ");
            bool validPassword = false;
            while (validPassword == false)
            {
                string password = Console.ReadLine();

                bool hasExclamation = password.Contains("!");
                int passwordLength = password.Length;
                bool hasUpper = false;
                bool hasLower = false;



                for (int u = 0; u <= passwordLength - 1; u++)
                {
                    if (Char.IsUpper(password, u) == true)
                    {
                        hasUpper = true;
                        


                    }
                    else if (Char.IsLower(password, u) == true)
                    {
                        hasLower = true;
                        

                    }
                    else
                    {
                       


                    }
                }

                if (passwordLength >= 7 && passwordLength <= 12 && hasLower == true && hasExclamation == true && hasUpper == true)
                {
                    Console.WriteLine("Password Valid and accepted");
                    validPassword = true;
                }
                else
                {
                    Console.WriteLine("error");
                    Console.WriteLine("Try Again");



                }
            }
            





        }
    }
}
