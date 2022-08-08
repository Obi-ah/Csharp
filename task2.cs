using System;


namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nations = { "india", "china", "taiwan", "vietnam", "pakistan", "iran", "egypt", "israel", "russia", "germany", "poland", "denmark", "sweden", "finland", "iceland"};

            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            bool passwordCheck = false;

            foreach (string nation in nations)
            {
                if(password == nation)
                {
                    Console.WriteLine("Login Successful");
                    passwordCheck = true;
                    break;
                }
            }

            if (!passwordCheck)
            {
                Console.WriteLine("Wrong Password");
            }
        }
    }
}
