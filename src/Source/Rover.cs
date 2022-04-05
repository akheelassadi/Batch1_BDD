using System;
using System.Collections.Generic;

namespace MarsRovers
{
  public static class Rover
  {
    public static string Direction { get; set; }
    public static Point Position { get; set; }

        public static void Turn(string turnDirection)
        {
            if (turnDirection == "L")
            {

                if (Direction == "N")
                {
                    Direction = "W";
                }

                else if (Direction == "E")
                {
                    Direction = "N";
                }

                else if (Direction == "W")
                {
                    Direction = "S";
                }

                else if (Direction == "S")
                {
                    Direction = "E";
                }
            }

            if (turnDirection == "R")
            {

                if (Direction == "N")
                {
                    Direction = "E";
                }

                else if (Direction == "E")
                {
                    Direction = "S";
                }

                else if (Direction == "W")
                {
                    Direction = "N";
                }

                else if (Direction == "S")
                {
                    Direction = "W";
                }
            }
        }

        public  static void Moves()
        {
            if (Direction == "N")
            {
                Position = new Point(1, 2);
            }
            else if(Direction == "S")
            {
                Position = new Point(1, 0);
            }
            else if(Direction == "E")
            {
                Position = new Point(2, 1);
            }
            else if (Direction == "W")
            {
                Position = new Point(0, 1);
            }
            else
            {
                Console.WriteLine($"Incorrect input {Direction}");
            }
        }

        public static bool IsRoverOutSideThePlateu()
        {

            if (Direction == "W" && Position.Equals(new Point(0,0)))
            {
                return true;
            }
            else if(Direction == "S" && Position.Equals(new Point(0, 0)))
            {
                return true;
            }
            else if (Direction == "E" && Position.Equals(new Point(5, 5)))
            {
                return true;
            }
            else if (Direction == "N" && Position.Equals(new Point(5, 5)))
            {
                return true;
            }
            else if (Direction == "N" && Position.Equals(new Point(0, 5)))
            {
                return true;
            }
            else if (Direction == "W" && Position.Equals(new Point(0, 5)))
            {
                return true;
            }
            else if (Direction == "E" && Position.Equals(new Point(5, 0)))
            {
                return true;
            }
            else if (Direction == "S" && Position.Equals(new Point(5, 0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}