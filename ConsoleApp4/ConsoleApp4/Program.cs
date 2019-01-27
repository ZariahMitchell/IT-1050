using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;


            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();
            

            System.Console.Write("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();
            

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            Console.WriteLine("Your full name is {0} {1} {2}", firstName , middleInitial , lastName);
            
            
            Console.WriteLine("What is your height in feet (4, 5 or 6)");
            int heightFeet = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("How tall are you in Inches??");
            double heightInches = Convert.ToDouble(Console.ReadLine());

            double totalHeightCM = heightInches * 2.54;
            Console.WriteLine("Your total height is {0} {1}" , totalHeightCM );


            Console.WriteLine("How Old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18) {

                Console.WriteLine("you can't vote");
            }

            bool isCitizen;

           Console.WriteLine("Are you a U.S. citizen? Type true or false");
            isCitizen = Convert.ToBoolean(Console.ReadLine());

            
           if  (isCitizen == true)
            {
                Console.WriteLine("Your can vote");
            }
           
           if (isCitizen == false)
            {

                Console.WriteLine("You can't vote ");
            }


            Console.WriteLine("Your full name is {0} {1} {2}   you are {3} years old", firstName, middleInitial, lastName,age, isCitizen) ;
            Console.WriteLine();
                                      // {4}

            Console.ReadKey();

        }
    }
}
