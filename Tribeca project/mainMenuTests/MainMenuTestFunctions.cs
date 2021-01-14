using System;
using Tribeca_project;
using Xunit;

namespace mainMenuTests
{
    public class MainMenuTestFunctions
    {
        [Fact]
        public void calculateAge_ValidDateOfBirth_ReturnsCorrectAge() //method name, input, expected 
        {
            //arrange
            DateTime personDOB = new DateTime(1997, 1, 1);



            //act
            int age = Tribeca_project.mainMenu.calculateAge(personDOB);


            //assert
            Assert.Equal(24, age); //(Expected, Actual)
        }

        [Fact]
        public void validateDOBInRange_AgeInRange_ReturnsTrue()
        {
            int Age = 75; //75 because age is in the ranges of 0 - 150

            bool result = Tribeca_project.mainMenu.validateDOBInRange(Age);

            Assert.True(result);
        }

        [Fact]
        public void validateDOBInRange_AgeNotInRange_ReturnsFalse()
        {
            int Age = 151; //151 because it is not within the ranges of 0-150

            bool result = Tribeca_project.mainMenu.validateDOBInRange(Age);

            Assert.False(result);
        }

        [Fact]
        public void PrintPersonStarSign_validDateOfBirth_ReturnsCorrectStarSign()
        {
            Person p = new Person();
            DateTime personDOB = new DateTime(1997, 1, 1); //My star sign is capricorn so i will use my own date of birth to do the testing
            p.DateOfBirth = personDOB;


            String starSign = p.PrintPersonStarSign(personDOB);

            Assert.Equal("Capricorn", starSign);

        }



    }
}
