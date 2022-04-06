using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsRovers.Steps
{
    [Binding]
    public class MoveRoverSteps
    {

        private readonly ScenarioContext _scenarioContext;
        private Rover rover;

        [When(@"the rover moves")]
        public void WhenTheRoverMoves()
        {
            rover = new Rover();
            rover.Moves();
        }

        [Then(@"the rover reaches new position \((\d+),(\d+)\) in the same ([NEWS]{1}).")]
        public void ThenTheRoverReachesNewPositionInTheSame_(int x, int y, string direction)
        {
            rover.Direction.Should().Be(direction);
            rover.Position.Should().Be(new Point(x, y));
        }

        [Then(@"the rover falls out of the plateau for \((\d+),(\d+)\) while facing ([NEWS]{1})")]
        public void ThenTheRoverFallsOutOfThePlateauForWhileFacingW(int x, int y, string direction)
        {
            rover.Direction = direction;
            rover.Position = new Point(x, y);
            Assert.IsTrue(rover.IsRoverOutSideThePlateu(), "Rover is inside the platue");
        }
    }
}
