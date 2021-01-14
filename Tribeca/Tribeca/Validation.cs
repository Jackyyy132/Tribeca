using System;
using System.Collections.Generic;
using System.Text;

namespace Tribeca
{
    class Validation
    {



        public static DateTime correctDOBFormat(int[] dayMonthYearArray)
        {
            DateTime correctDOBFormatter = new DateTime();
            try
            {
                correctDOBFormatter = new DateTime(dayMonthYearArray[2], dayMonthYearArray[1], dayMonthYearArray[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, invalid date. Please try again.");
                mainMenu.getDOB();
            }


            return correctDOBFormatter;
        }
        public static bool validateDOBInRange(int personAge)
        {
            bool validDOB = false;
            do
            {  
                if (personAge >= 0 && personAge <= 150)
                {
                        Console.WriteLine("Age is accepted: " + personAge);
                        validDOB = true;
                }
                else
                {
                    Console.WriteLine("Age is not accepted: " + personAge);
                    mainMenu.getDOB();
                }
                
                
            } while (validDOB == false);

            return validDOB;

        }


        
    }
}
