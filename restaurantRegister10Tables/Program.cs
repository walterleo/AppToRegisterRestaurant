using System;

namespace restaurantRegister10Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10] { "", "", "", "", "", "", "", "", "", "" };
            int arrayCurrentIndex = 0;
            bool userType;

            Console.WriteLine("Welcome to the best place to enjoy the flavour");
                        
            while (true)
            {
                if (arrayCurrentIndex == 10)
                {
                    Console.WriteLine("The restaurant is full, please try again");
                    Environment.Exit(0);
                }
                Console.WriteLine("\n \n Are you a registered user? write true, or write false to register ");
                userType = Convert.ToBoolean(Console.ReadLine());
                if (userType == true)
                {
                    Console.WriteLine("Hello, you are a registered user, please your credentials please");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you search is  {0}", userToSearch);
                    int index = Array.IndexOf(userNames, userToSearch);
                    if (index == -1)
                    {
                        Console.WriteLine("User not found, try again or register ");
                    }
                    else
                    {
                        Console.WriteLine("Welcome {0}, it is a plesuare to serve you", userNames[index]);
                    }
                }
                else if (userType == false) 
                {
                    Console.WriteLine("Please write and remember your user Name");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Your user has been saved successfully\n" +
                       "Your user name is {0}", userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;
                }
            }
        }
    }
}
