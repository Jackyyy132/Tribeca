using System;
using System.Collections.Generic;
using System.Text;

namespace Tribeca
{
    class mainMenu
    {
        static int[] dayMonthYearArray = new int[3];
        public static void Menu()
        {

            String userMenuChoice;
            do
            {
                Console.WriteLine("____________________________________________________");
                Console.WriteLine("A. Create Person");
                Console.WriteLine("E. Exit");
                Console.WriteLine("____________________________________________________");
                userMenuChoice = Console.ReadLine().ToUpper();


                if (userMenuChoice.Equals("A"))
                {
                    createPerson();
                }

            } while (!userMenuChoice.Equals("E"));
            
        }

        public static void createPerson()
        {
            String name;
            String surname;
            DateTime correctDateOfBirthFormat;
            int age;


            Console.WriteLine("What is your name: ");
            name = Console.ReadLine();

            Console.WriteLine("What is your surname: ");
            surname = Console.ReadLine();

            Console.WriteLine("What is your DOB? ");
            dayMonthYearArray = getDOB();

            correctDateOfBirthFormat = Validation.correctDOBFormat(dayMonthYearArray);

            age = calculateAge(correctDateOfBirthFormat);

            Person p = new Person(name, surname, age, correctDateOfBirthFormat);


            Console.WriteLine(p.toString());

        }


        public static int[] getDOB()
        {
            int day;
            int month;
            int year;

            Console.WriteLine("Please write your date of birth in the format of: DD/MM/YYYY");
            Console.WriteLine("");
            Console.WriteLine("What day was you born?");
            day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What month was you born?");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What year was you born?");
            year = Convert.ToInt32(Console.ReadLine());

            dayMonthYearArray[0] = day;
            dayMonthYearArray[1] = month;
            dayMonthYearArray[2] = year;


            //Console.WriteLine(personDOB.ToString("dd/MM/yyyy"));

            return dayMonthYearArray;

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
            int Age = getTodaysDate().Year - personDOB.Year;

            if (personDOB > getTodaysDate().AddYears(-Age))
            {
                Age--;
            }
            Console.WriteLine(Age);
            return Age;
        }
    }
}
