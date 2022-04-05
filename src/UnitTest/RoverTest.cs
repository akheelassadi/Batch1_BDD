using FluentAssertions;
using NUnit.Framework;

namespace MarsRovers.UnitTest
{
    class RoverTest
    {

        [Test]
        public void RoverTestInitiallize()
        {
            Rover.Direction = "N";
            Rover.Position = new Point(1, 2);
            Rover.Direction.Should().Be("N");
            Rover.Position.Should().Be(new Point(1, 2));

        }

        [Test]
        public void RoverShouldTurnLeftFromNorth()
        {
            Rover.Direction = "N";
            Rover.Position = new Point(1, 2);
            Rover.Turn("L");
            Rover.Direction.Should().Be("W");
            Rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnLeftFromEast()
        {
            Rover.Direction = "E";
            Rover.Position = new Point(1, 2);
            Rover.Turn("L");
            Rover.Direction.Should().Be("N");
            Rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnLeftFromSouth()
        {
            Rover.Direction = "S";
            Rover.Position = new Point(1, 2);
            Rover.Turn("L");
            Rover.Direction.Should().Be("E");
            Rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnLeftFromWest()
        {
            Rover.Direction = "W";
            Rover.Position = new Point(1, 2);
            Rover.Turn("L");
            Rover.Direction.Should().Be("S");
            Rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnRightFromNorth()
        {
            Rover.Direction = "N";
            Rover.Position = new Point(1, 2);
            Rover.Turn("R");
            Rover.Direction.Should().Be("E");
            Rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnRightFromEast()
        {
            Rover.Direction = "E";
            Rover.Position = new Point(1, 2);
            Rover.Turn("R");
            Rover.Direction.Should().Be("S");
            Rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnRightFromSouth()
        {
            Rover.Direction = "S";
            Rover.Position = new Point(1, 2);
            Rover.Turn("R");
            Rover.Direction.Should().Be("W");
            Rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnRightFromWest()
        {
            Rover.Direction = "W";
            Rover.Position = new Point(1, 2);
            Rover.Turn("R");
            Rover.Direction.Should().Be("N");
            Rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverMovementNorth()
        {

            Rover.Direction = "N";
            Rover.Position = new Point(1, 1);
            Rover.Moves();
            Rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverMovementFromSouth()
        {

            Rover.Direction = "S";
            Rover.Position = new Point(1, 1);
            Rover.Moves();
            Rover.Position.Should().Be(new Point(1, 0));

        }

        [Test]
        public void RoverMovementFromEast()
        {

            Rover.Direction = "E";
            Rover.Position = new Point(1, 1);
            Rover.Moves();
            Rover.Position.Should().Be(new Point(2, 1));

        }

        [Test]
        public void RoverMovementFromWest()
        {
            Rover.Direction = "W";
            Rover.Position = new Point(1, 1);
            Rover.Moves();
            Rover.Position.Should().Be(new Point(0, 1));
        }

        [Test]
        public void IsRoverOutOfPlatue1()
        {
            Rover.Direction = "W";
            Rover.Position = new Point(0, 0);
            bool result = Rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue2()
        {
            Rover.Direction = "S";
            Rover.Position = new Point(0, 0);
            bool result = Rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue3()
        {
            Rover.Direction = "E";
            Rover.Position = new Point(5, 5);
            bool result = Rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue4()
        {
            Rover.Direction = "N";
            Rover.Position = new Point(5, 5);
            bool result = Rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue5()
        {
            Rover.Direction = "N";
            Rover.Position = new Point(0, 5);
            bool result = Rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue6()
        {
            Rover.Direction = "W";
            Rover.Position = new Point(0, 5);
            bool result = Rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue7()
        {
            Rover.Direction = "E";
            Rover.Position = new Point(5, 0);
            bool result = Rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue8()
        {
            Rover.Direction = "S";
            Rover.Position = new Point(5, 0);
            bool result = Rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }
    }
    }
