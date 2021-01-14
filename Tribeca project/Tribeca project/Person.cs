using System;

namespace Tribeca_project
{
    public class Person
    {
        //Setting private fields
        private String name;
        private String surname;
        private int age;
        private DateTime dateOfBirth;
        public String starSign;


        //public properties to read and write to the private fields (getters and setters)
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get
            {
                //calculates age and will return the age of the person
                return mainMenu.calculateAge(dateOfBirth);
            }
            set { age = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                dateOfBirth = value;
                int personAge = mainMenu.calculateAge(dateOfBirth);
                
                if(personAge >= 0 && personAge <= 150)
                {
                    dateOfBirth = value;
                }
                else
                {
                    //Throw exception if the age does not meet the specified age requirements (in this case 0 - 150)
                    throw new Exception("Age is not within the appropriate range. (Range is 0 - 150)");
                }


                
            }
            
    }
        public String StarSign
        {
            get { return starSign; }
        }

        //toString method when called creates a nice display for the user to display the object fields.
        public String toString()
        {
            return "Name: " + this.name + Environment.NewLine + "Surname: " + this.surname + Environment.NewLine + "Age: " + this.age + Environment.NewLine + "Date of birth: " + this.dateOfBirth.ToString("dd/MM/yyyy") + Environment.NewLine + "Star Sign: " + this.starSign;
        }
    }


}
