namespace UserCreation_and_Storage
{
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography.X509Certificates;
    using static System.Console;
        
        internal class Program
    {
        static void Main(string[] args)
        {
            List<string> users = new List<string>();


            WriteLine("Would you like to create a new user? Y for yes; N for no.");
            char yOrN = char.ToLower(char.Parse(ReadLine()));

            if (yOrN == 'y')
            {
                char loopResponse = 'y';
                while (loopResponse == 'y')
                {
                    NewUser();
                    users.Add(userName);
                }
            }
            else
            {
                WriteLine("Okay! Goodbye!");
                
            }

        }


        public static string NewUser()
        {
            string userName;
            WriteLine("Welcome! Please enter your first and last name, separated by a space.");
            userName = ReadLine();
            return userName;
            


        }
    }
}
    