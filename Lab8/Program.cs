using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Name = new string[20] { "Justin", "Dorothy", "Jocelyn", "Brian", "Bradley", "MichaeCl", "MichaeCo",
            "Ross", "Catherine", "Jacob", "Kim Driscoll", "Shawn", "Sean", "Chris", "Bruce", "Rabin", "Anna", "Jeffrey", "Jasmine", "David"};

            string[] Hometown = new string[20] { "Hudsonville, MI", "Birmingham, AL", "Grand Rapids, MI", "Kentwood, MI", "Lansing, MI",
            "Rockford, MI", "Hartford, CT", "Joliet, IL", "Tampa, FL", "Chicago, IL", "Detroit, MI", "Columbus, OH",
            "Atlanta, GA", "Austin, TX", "Charleston, WV", "Macon, GA", "Ypsilanti, MI", "Inkster, MI", "Raleigh, NC", "Toledo, OH"};

            string[] Food = new string[20] { "Tacos", "Salmon", "Spaghetti", "Turkey", "Ham", "Potatoes", "Eggs", "Bacon", "Sausage",
            "Chicken", "Steak", "Gyro", "Salad", "Nachos", "Fish", "Carrots", "Chips", "Cookies", "Cake", "Hummus"};

            bool Continue = true;
             while (Continue)
            {
                Console.WriteLine("Which student would you like to learn more about? Enter a number from 1 - 20");
                int sNum = int.Parse(Console.ReadLine());

                if (sNum >= 0 && sNum <= 19)
                {
                    Console.WriteLine($"Student {sNum} is {Name[sNum]}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("That student does not exist. Please try again");
                }
                Console.WriteLine("Do you want to continue? y/n");
                string userEnd = Console.ReadLine();


                if (userEnd == "n")
                {
                    Console.WriteLine("Thanks");
                    Continue = false;
                }
                 
            
                Console.WriteLine($"Would you like to know more about {Name[sNum]}? Enter hometown or favorite food");
                string nextReply = Console.ReadLine();

                if (nextReply == "hometown")
                {
                    Console.WriteLine($"{Name[sNum]} is from {Hometown[sNum]}");
                    Console.ReadLine();
                }
                else if (nextReply == "favorite food")
                    {Console.WriteLine($"{Name[sNum]} likes to eat {Food[sNum]}");
                    }
                else
                {
                    Console.WriteLine("That data does not exist. Please try again");
                }
                Console.WriteLine("Do you want to continue? y/n");
                userEnd = Console.ReadLine();


                if (userEnd == "n")
                {
                    Console.WriteLine("Thanks");
                    Console.ReadKey();
                    Continue = false;
                }
            }
            
        }
    }
}
