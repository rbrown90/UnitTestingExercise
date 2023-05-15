using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new Calculator();// create a Calculator object


            //Act
            var actual = test.Add(num1, num2, num3); // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            var test = new Calculator();//Arrange

            var actual = test.Subtract(minuend, subtrhend);//Act

            Assert.Equal(expected, actual);//Assert

        }

        [Theory]
        [InlineData(2 , 5, 10)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            var test = new Calculator();//Arrange

            var actual = test.Multiply(num1, num2);//Act

            Assert.Equal(expected, actual);//Assert

        }

        [Theory]
        [InlineData(20 , 5 , 4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            var test = new Calculator();//Arrange

            var actual = test.Divide(num1, num2);//Act

            Assert.Equal(expected, actual);//Assert

        }

    }
}
