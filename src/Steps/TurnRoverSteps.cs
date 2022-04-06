using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace MarsRovers.Steps
{
    [Binding]
    public class TurnRoverSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Rover rover;

        public TurnRoverSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Rover is in plateau at \((\d+),(\d+)\) co-ordinates and facing ([NEWS]{1})")]
        public void GivenRoverIsInPlateauAtCo_OrdinatesAndFacing(int x, int y, string direction)
        {
            Point point = new Point(x,y);
            rover = new Rover();
            rover.Position = point;
            rover.Direction = direction;
            
        }

        [When(@"the rover turns ([LR]{1})")]
        public void WhenTheRoverTurns(string turnDirection)
        {
            rover.Turn(turnDirection);
        }

        [Then(@"Rover turns to a new direction ([NEWS]{1}) with same cordinates \((\d+),(\d+)\)")]
        public void ThenRoverTurnsToANewDirectionWithSameCordinates(string direction,int x, int y)
        {
            rover.Direction.Should().Be(direction);
            rover.Position.Should().Be(new Point(x, y));
 
        }
    }
}
