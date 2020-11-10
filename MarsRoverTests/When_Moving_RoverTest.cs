using MarsRoverApp;
using Moq;
using System;
using Xunit;

namespace MarsRoverTests
{
    public class When_Moving_RoverTest
    {
        [Fact]
        public void SpinLeft()
        {
            var mock = new Mock<IRobot>();
            mock.SetupGet(m => m.direction).Returns("N");
            mock.Object.SpinLeft();
            Console.WriteLine(mock.Object.direction);
            Assert.Equal("W", mock.Object.direction);

        }

        [Fact]
        public void SpinRight()
        {
            var mock = new Mock<IRobot>();
            mock.SetupGet(m => m.direction).Returns("N");
            mock.Object.SpinRight();
            Console.WriteLine(mock.Object.direction);
            Assert.Equal("E", mock.Object.direction);

        }

        [Fact]
        public void StepForward()
        {
            var mock = new Mock<IRobot>();
            mock.SetupGet(m => m.x).Returns(1);
            mock.SetupGet(m => m.y).Returns(2);
            mock.SetupGet(m => m.direction).Returns("N");
            mock.Object.StepForward();
            Assert.Equal(3, mock.Object.y);

        }

        [Fact]
        public void Move()
        {
            var mock = new Mock<IRobot>();
            mock.SetupGet(m => m.x).Returns(1);
            mock.SetupGet(m => m.y).Returns(2);
            mock.SetupGet(m => m.direction).Returns("N");
            mock.SetupGet(m => m.roverCommands).Returns("MMRMMRMMRM");

            mock.Object.Move();
            Assert.Equal("1 3 N", mock.Object.x + " " + mock.Object.y + mock.Object.direction);

        }
    }
}
