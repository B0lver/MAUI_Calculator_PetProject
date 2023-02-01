using Calculus_Library.Operations.Base;
using Calculus_Library.Operations.BasicMath;

namespace Calculus_Tests.BasicMath
{
    public class Sum
    {
        [Fact]
        public void IntegerSum()
        {
            //Arrange
            Plus<int> operation = new(new BaseValue<int>(1), new BaseValue<int>(2));
            //Act
            var res = operation.GetValue();
            //Assert
            Assert.Equal(expected: 3, actual: res);
        }

        [Fact]
        public void DoubleSum()
        {
            //Arrange
            Plus<double> operation = new(new BaseValue<double>(1.78), new BaseValue<double>(2.34));
            //Act
            var res = operation.GetValue();
            //Assert
            Assert.Equal(expected: 1.78 + 2.34, actual: res);
        }

        [Fact]
        public void SumsCascade_AsFirstArg() 
        {
            //Arrange
            Plus<int> operation1 = new(new BaseValue<int>(2), new BaseValue<int>(5));
            Plus<int> operation2 = new(operation1, new BaseValue<int>(4));
            //Act
            var res = operation2.GetValue();
            //Assert
            Assert.Equal(expected: 11, actual: res);
        }

        [Fact]
        public void SumsCascade_AsSecondArg()
        {
            //Arrange
            Plus<int> operation1 = new(new BaseValue<int>(5), new BaseValue<int>(1));
            Plus<int> operation2 = new(new BaseValue<int>(9), operation1);
            //Act
            var res = operation2.GetValue();
            //Assert
            Assert.Equal(expected: 15, actual: res);
        }

        [Fact]
        public void SumsCascade_AsBoth()
        {
            //Arrange
            Plus<int> operation1 = new(new BaseValue<int>(2), new BaseValue<int>(4));
            Plus<int> operation2 = new(new BaseValue<int>(1), new BaseValue<int>(9));
            Plus<int> operation3 = new(operation1, operation2);
            //Act
            var res = operation3.GetValue();
            //Assert
            Assert.Equal(expected: 16, actual: res);
        }

        [Fact]
        public void SumsCascade_FirstArgNegative()
        {
            //Arrange
            Plus<int> operation = new(new BaseValue<int>(-4), new BaseValue<int>(2));
            //Act
            var res = operation.GetValue();
            //Assert
            Assert.Equal(expected: -2, actual: res);
        }

        [Fact]
        public void SumsCascade_SecondArgNegative()
        {
            //Arrange
            Plus<int> operation = new(new BaseValue<int>(7), new BaseValue<int>(-9));
            //Act
            var res = operation.GetValue();
            //Assert
            Assert.Equal(expected: -2, actual: res);
        }

        [Fact]
        public void SumsCascade_BothArgsNegative()
        {
            //Arrange
            Plus<int> operation = new(new BaseValue<int>(-8), new BaseValue<int>(-29));
            //Act
            var res = operation.GetValue();
            //Assert
            Assert.Equal(expected: -37, actual: res);
        }
    }
}
