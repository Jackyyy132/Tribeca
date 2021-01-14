using System;


namespace Tribeca
{

    class Person
    {

        private String name;
        private String surname;
        private int age;
        private DateTime dateOfBirth;



        public Person(String pName, String pSurname, int pAge, DateTime pDateOfBirth)
        {
            name = pName;
            surname = pSurname;
            age = pAge;
            dateOfBirth = pDateOfBirth;
        }
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

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set 
            { 
                if (Validation.validateDOBInRange(this.age) == true){
                    dateOfBirth = value;
                }
                else
                {
                    Console.WriteLine("Invalid DOB");
                }
                 
            }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public String toString()
        {
            return "Name: " + this.name + Environment.NewLine + "Surname: " + this.surname + Environment.NewLine + "Age: " + this.age + Environment.NewLine + "Date of birth: " + this.dateOfBirth;
        }

    }
}
