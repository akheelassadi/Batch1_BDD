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
        //private Rover rover;

        public MoveRoverSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"the rover moves")]
        public void WhenTheRoverMoves()
        {
            Rover.Moves();
        }

        [Then(@"the rover reaches new position \((\d+),(\d+)\) in the same ([NEWS]{1}).")]
        public void ThenTheRoverReachesNewPositionInTheSame_(int x, int y, string direction)
        {
            Rover.Direction.Should().Be(direction);
            Rover.Position.Should().Be(new Point(x, y));
        }

        [Then(@"the rover falls out of the plateau")]
        public void ThenTheRoverFallsOutOfThePlateau()
        {

            Assert.IsTrue(Rover.IsRoverOutSideThePlateu(), "Rover is inside the platue");
        }


    }
}
