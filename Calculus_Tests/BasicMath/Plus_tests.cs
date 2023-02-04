using Calculus_Library.Operations.Base;
using Calculus_Library.Operations.BasicMath;

namespace Calculus_Tests.BasicMath
{
    public class Plus_tests
    {
        [Fact]
        public void IntegerSum()
        {
            //Arrange
            Plus operation = new(new BaseValue(1), new BaseValue(2));
            //Act
            var res = operation.GetValue();
            //Assert
            Assert.Equal(expected: 3, actual: res);
        }

        [Fact]
        public void DoubleSum()
        {
            //Arrange
            Plus operation = new(new BaseValue(1.78), new BaseValue(2.34));
            //Act
            var res = operation.GetValue();
            //Assert
            Assert.Equal(expected: 1.78 + 2.34, actual: res);
        }

        [Fact]
        public void SumsCascade_AsFirstArg() 
        {
            //Arrange
            Plus operation1 = new(new BaseValue(2), new BaseValue(5));
            Plus operation2 = new(operation1, new BaseValue(4));
            //Act
            var res = operation2.GetValue();
            //Assert
            Assert.Equal(expected: 11, actual: res);
        }

        [Fact]
        public void SumsCascade_AsSecondArg()
        {
            //Arrange
            Plus operation1 = new(new BaseValue(5), new BaseValue(1));
            Plus operation2 = new(new BaseValue(9), operation1);
            //Act
            var res = operation2.GetValue();
            //Assert
            Assert.Equal(expected: 15, actual: res);
        }

        [Fact]
        public void SumsCascade_AsBoth()
        {
            //Arrange
            Plus operation1 = new(new BaseValue(2), new BaseValue(4));
            Plus operation2 = new(new BaseValue(1), new BaseValue(9));
            Plus operation3 = new(operation1, operation2);
            //Act
            var res = operation3.GetValue();
            //Assert
            Assert.Equal(expected: 16, actual: res);
        }

        [Fact]
        public void SumsCascade_FirstArgNegative()
        {
            //Arrange
            Plus operation = new(new BaseValue(-4), new BaseValue(2));
            //Act
            var res = operation.GetValue();
            //Assert
            Assert.Equal(expected: -2, actual: res);
        }

        [Fact]
        public void SumsCascade_SecondArgNegative()
        {
            //Arrange
            Plus operation = new(new BaseValue(7), new BaseValue(-9));
            //Act
            var res = operation.GetValue();
            //Assert
            Assert.Equal(expected: -2, actual: res);
        }

        [Fact]
        public void SumsCascade_BothArgsNegative()
        {
            //Arrange
            Plus operation = new(new BaseValue(-8), new BaseValue(-29));
            //Act
            var res = operation.GetValue();
            //Assert
            Assert.Equal(expected: -37, actual: res);
        }
    }
}
