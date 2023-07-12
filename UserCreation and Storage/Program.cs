namespace UserCreation_and_Storage
{
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography.X509Certificates;
    using static System.Console;
    
        
        internal class Program
    {
        static void Main(string[] args)
        {
            //Creates string in which to store users' names
            List<string> users = new List<string>();


            WriteLine("Would you like to create a new user? Y for yes; N for no.");
            char yOrN = char.ToLower(char.Parse(ReadLine()));
            if (yOrN == 'y')
            {
                char loopResponse = 'y';
                while (loopResponse == 'y')
                {
                    users.Add(NewUser());
                    WriteLine("Would you like to add another user? y/n");
                    loopResponse = char.ToLower(char.Parse(ReadLine()));
                }
                WriteLine("Would you like to display users? y/n");
                char dispUser = char.ToLower(char.Parse(ReadLine()));
                if (dispUser == 'y')
                {
                    DisplayUsers(users);
                }

                else
                {
                    WriteLine("Okay! Goodbye!");
                    ReadLine();
                }
            }
            if (yOrN == 'n')
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

        public static void DisplayUsers(List<string> users)
        {
            foreach(string i in users)
            {
                WriteLine(i);
            }
        }
    }
}
    