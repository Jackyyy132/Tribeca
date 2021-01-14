using System;
using System.Collections.Generic;
using System.Text;

namespace Tribeca_project
{
    public class mainMenu
    {
        public static void Menu()
        {
            DateTime personDOB = new DateTime(1997, 1, 1);

            //Create object person with specific details: "YYYY/MM/DD"
            Person p = new Person();


            
            

            //Using setters to set the values of our object
            p.Name = "Jacky";
            
            p.Surname = "Tran";
            p.DateOfBirth = personDOB;

            //Call calculate age method with the persons date of birth in parameter, to calculate age of the person with the given date of birth
            p.Age = calculateAge(personDOB);

            //Using extension class to print persons star sign in accordance to the date of birth that was inputted.
            p.PrintPersonStarSign(personDOB);

            Console.WriteLine(p.starSign);

            //Trying to do reflection to access private name field but it is quite confusing
            String test = Utilities.GetPersonsName<Person, String>(p, p.Name);

            //Calling toString method in person class to give a nice display of the object class
            Console.WriteLine(p.toString());
        }

        

        public static DateTime getTodaysDate()
        {
            //Get todays date in format dd/MM/yyyy/hh:mm:ss
            DateTime todaysDate = DateTime.Today;
            //MM = months, mm = minutes
            //String todaysDateWithoutTime = DateTime.Now.ToString("dd/MM/yyyy");

            return todaysDate;

        }
        public static int calculateAge(DateTime personDOB)
        {
            //Calculates the age of the person using todays year and subtracting it from the persons date of birth year
            int Age = getTodaysDate().Year - personDOB.Year;

            //In case of leap year https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-based-on-a-datetime-type-birthday?noredirect=1
            if (personDOB > getTodaysDate().AddYears(-Age))
            {
                Age--;
            }

            return Age;
        }

        public static bool validateDOBInRange(int personAge)
        {
            bool validDOB;
                //Check if persons age is between the ranges specified
                if (personAge >= 0 && personAge <= 150)
                {
                    Console.WriteLine("Age is accepted: " + personAge);
                    validDOB = true;
                }
                else
                {
                    Console.WriteLine("Age is not accepted: " + personAge);
                    validDOB = false;
            }


            return validDOB;

        }

    }
}
