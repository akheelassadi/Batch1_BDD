using FluentAssertions;
using NUnit.Framework;

namespace MarsRovers.UnitTest
{
    class RoverTest
    {

        [Test]
        public void RoverTestInitiallize()
        {
            Rover rover = new Rover();
            rover.Direction = "N";
            rover.Position = new Point(1, 2);
            rover.Direction.Should().Be("N");
            rover.Position.Should().Be(new Point(1, 2));

        }

        [Test]
        public void RoverShouldTurnLeftFromNorth()
        {
            Rover rover = new Rover();
            rover.Direction = "N";
            rover.Position = new Point(1, 2);
            rover.Turn("L");
            rover.Direction.Should().Be("W");
            rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnLeftFromEast()
        {
            Rover rover = new Rover();
            rover.Direction = "E";
            rover.Position = new Point(1, 2);
            rover.Turn("L");
            rover.Direction.Should().Be("N");
            rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnLeftFromSouth()
        {
            Rover rover = new Rover();
            rover.Direction = "S";
            rover.Position = new Point(1, 2);
            rover.Turn("L");
            rover.Direction.Should().Be("E");
            rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnLeftFromWest()
        {
            Rover rover = new Rover();
            rover.Direction = "W";
            rover.Position = new Point(1, 2);
            rover.Turn("L");
            rover.Direction.Should().Be("S");
            rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnRightFromNorth()
        {
            Rover rover = new Rover();
            rover.Direction = "N";
            rover.Position = new Point(1, 2);
            rover.Turn("R");
            rover.Direction.Should().Be("E");
            rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnRightFromEast()
        {
            Rover rover = new Rover();
            rover.Direction = "E";
            rover.Position = new Point(1, 2);
            rover.Turn("R");
            rover.Direction.Should().Be("S");
            rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnRightFromSouth()
        {
            Rover rover = new Rover();
            rover.Direction = "S";
            rover.Position = new Point(1, 2);
            rover.Turn("R");
            rover.Direction.Should().Be("W");
            rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverShouldTurnRightFromWest()
        {
            Rover rover = new Rover();
            rover.Direction = "W";
            rover.Position = new Point(1, 2);
            rover.Turn("R");
            rover.Direction.Should().Be("N");
            rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverMovementNorth()
        {
            Rover rover = new Rover();
            rover.Direction = "N";
            rover.Position = new Point(1, 1);
            rover.Moves();
            rover.Position.Should().Be(new Point(1, 2));
        }

        [Test]
        public void RoverMovementFromSouth()
        {
            Rover rover = new Rover();
            rover.Direction = "S";
            rover.Position = new Point(1, 1);
            rover.Moves();
            rover.Position.Should().Be(new Point(1, 0));

        }

        [Test]
        public void RoverMovementFromEast()
        {
            Rover rover = new Rover();
            rover.Direction = "E";
            rover.Position = new Point(1, 1);
            rover.Moves();
            rover.Position.Should().Be(new Point(2, 1));

        }

        [Test]
        public void RoverMovementFromWest()
        {
            Rover rover = new Rover();
            rover.Direction = "W";
            rover.Position = new Point(1, 1);
            rover.Moves();
            rover.Position.Should().Be(new Point(0, 1));
        }

        [Test]
        public void IsRoverOutOfPlatue1()
        {
            Rover rover = new Rover();
            rover.Direction = "W";
            rover.Position = new Point(0, 0);
            bool result = rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue2()
        {
            Rover rover = new Rover();
            rover.Direction = "S";
            rover.Position = new Point(0, 0);
            bool result = rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue3()
        {
            Rover rover = new Rover();
            rover.Direction = "E";
            rover.Position = new Point(5, 5);
            bool result = rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue4()
        {
            Rover rover = new Rover();
            rover.Direction = "N";
            rover.Position = new Point(5, 5);
            bool result = rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue5()
        {
            Rover rover = new Rover();
            rover.Direction = "N";
            rover.Position = new Point(0, 5);
            bool result = rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue6()
        {
            Rover rover = new Rover();
            rover.Direction = "W";
            rover.Position = new Point(0, 5);
            bool result = rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue7()
        {
            Rover rover = new Rover();
            rover.Direction = "E";
            rover.Position = new Point(5, 0);
            bool result = rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }

        [Test]
        public void IsRoverOutOfPlatue8()
        {
            Rover rover = new Rover();
            rover.Direction = "S";
            rover.Position = new Point(5, 0);
            bool result = rover.IsRoverOutSideThePlateu();
            result.Should().Be(true);
        }
    }
    }
