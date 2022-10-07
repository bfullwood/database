using System;

namespace Student_Database_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> students = new List<string> { "Brandon", "Dennis", "Megen", "Amy"};

            List<string> favFoods = new List<string> { "Alfredo", "Crab legs", "Chicken Parm", "Dr.Peper",
           };

            List<string> homeTown = new List<string> { "Mt.Clemens, MI", "Detroit, MI", "Detroit, MI", "Pensacola, FL"};

            bool goAgain = true;

           

            while (goAgain)
            {
                Console.WriteLine("Hi, Welcome to our school! Would you like to 'learn' about a student or 'add' a new student to the lists");

                string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "add" || answer == "a")
                {
                    Console.WriteLine("Please input the student's name: ");
                    students.Add(Console.ReadLine());

                    Console.WriteLine("Next Please input the student's favorite food");
                    favFoods.Add(Console.ReadLine());

                    Console.WriteLine("Lastly, please tell me their home town");
                    homeTown.Add(Console.ReadLine());
                }
                else if (answer == "learn" || answer == "l")
                {
                    
                    Console.WriteLine($"\nPlease enter a number, 1 through {students.Count}, to look up your student.\n");

                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input > students.Count)
                    {
                        Console.WriteLine("\nI'm sorry, that number is too high. Please enter another to look up your student!\n");
                        continue;
                    }

                    int indexStudent = input - 1;

                    Console.WriteLine("\nYou have selected student: " + students[indexStudent] + "\n");


                    bool runAgain = true;

                    while (runAgain)
                    {

                        Console.WriteLine("Please enter 'Hometown' or 'Favorite Food' to look up information on " + students[indexStudent] + ".\n");
                        Console.WriteLine("If you wanted more information than that...Well, blame Kevin.\n");

                        string choice = Console.ReadLine();
                        Console.WriteLine();

                        if (choice == "Hometown" || choice == "hometown" || choice == "town")
                        {
                            Console.WriteLine(students[indexStudent] + "'" + "s home town is: " + homeTown[indexStudent] + ".");
                            runAgain = false;
                        }
                        else if (choice == "Favorite Food" || choice == "Food")
                        {
                            Console.WriteLine(students[indexStudent] + "'" + "s favorite food is: " + favFoods[indexStudent] + ".");
                            runAgain = false;
                        }
                        else
                        {
                          
                            Console.WriteLine("Please enter either 'Hometown' or 'Favorite Foods' to view info for " + students[indexStudent] + ".\n");
                        }

                    }

                    goAgain = askAgain();
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand that, let's try that again");
                    
                    continue;
                }


            }

        }
        public static bool askAgain()
        {
            Console.WriteLine("\nWould you like to more information on another student? Y/N?\n");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("\nThank you for using our database!");
                return false;
            }
            else
            {
                Console.WriteLine("\nI didn't understand that. Please try again!");
                return askAgain();
            }
        }

    }
}