using System;
using System.Collections.Generic;
using System.Text;

namespace Tribeca_project
{
    public static class Star_Sign //Need to make the class public and static for extension methods and to be used by other classes 
                                  //static so you dont need to make an object of this class to use its methods

    //https://www.youtube.com/watch?v=QIJNyvFWaUo&t=559s reference
    {
        public static String PrintPersonStarSign(this Person p, DateTime dateOfBirth) 
        {
            switch (dateOfBirth.Month)
            {
                case 1:
                    if (dateOfBirth.Day < 20)
                    {
                        p.starSign = "Capricorn";
                    }
                    else
                    {
                        p.starSign = "Aquarius";
                    }         
                    break;


                case 2:
                    if (dateOfBirth.Day < 19)
                    {
                        p.starSign = "Aquarius";
                    }
                    else
                    {
                        p.starSign = "Pisces";
                    }
                    break;


                case 3:
                    if (dateOfBirth.Day < 21)
                    {
                        p.starSign = "Pisces";
                    }
                    else
                    {
                        p.starSign = "Aries";
                    }
                    break;


                case 4:
                    if (dateOfBirth.Day < 20)
                    {
                        p.starSign = "Aries";
                    }
                    else
                    {
                        p.starSign = "Taurus";
                    }
                    break;


                case 5:
                    if (dateOfBirth.Day < 21)
                    {
                        p.starSign = "Taurus";
                    }
                    else
                    {
                        p.starSign = "Gemini";
                    }
                    break;


                case 6:
                    if (dateOfBirth.Day < 21)
                    {
                        p.starSign = "Gemini";
                    }
                    else
                    {
                        p.starSign = "Cancer";
                    }
                    break;


                case 7:
                    if (dateOfBirth.Day < 23)
                    {
                        p.starSign = "Cancer";
                    }
                    else
                    {
                        p.starSign = "Leo";
                    }
                    break;


                case 8:
                    if (dateOfBirth.Day < 23)
                    {
                        p.starSign = "Leo";
                    }
                    else
                    {
                        p.starSign = "Virgo";
                    }
                    break;


                case 9:
                    if (dateOfBirth.Day < 23)
                    {
                        p.starSign = "Virgo";
                    }
                    else
                    {
                        p.starSign = "Libra";
                    }
                    break;


                case 10:
                    if (dateOfBirth.Day < 23)
                    {
                        p.starSign = "Libra";
                    }
                    else
                    {
                        p.starSign = "Scorpio";
                    }
                    break;


                case 11:
                    if (dateOfBirth.Day < 22)
                    {
                        p.starSign = "Scorpio";
                    }
                    else
                    {
                        p.starSign = "Sagittarius";
                    }
                    break;


                case 12:
                    if (dateOfBirth.Day < 22)
                    {
                        p.starSign = "Sagittarius";
                    }
                    else
                    {
                        p.starSign = "Capricorn";
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input. Cannot get star sign.");
                    p.starSign = "Invalid Star Sign";
                    break;
            }

            return p.starSign;
        }
    }
}
