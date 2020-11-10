using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverApp
{
    public class Robot : IRobot
    {
        protected int x1;           //x coordinate of the current rover position
        protected int y1;           //y coordinate of the current rover position
        protected string direction; //coordinal direction of the current rover position
        protected string _roverCommands; //commands used to move the rover

        public Robot(string location, string roverCommands)
        {
            Int32.TryParse(location.Split(" ")[0], out x1);
            Int32.TryParse(location.Split(" ")[1], out y1);
            direction = location.Split(" ")[2];
            _roverCommands = roverCommands;
        }
        public int x => x1;

        public int y => y1;

        string IRobot.direction => direction;

        string IRobot.roverCommands => _roverCommands;

        public void SpinLeft()
        {
            string directionLeft = string.Empty;
            switch (direction.ToUpper())
            {
                case "N":
                    directionLeft = "W";
                    break;
                case "E":
                    directionLeft = "N";
                    break;
                case "S":
                    directionLeft = "E";
                    break;
                case "W":
                    directionLeft = "S";
                    break;
                default:
                    throw new ArgumentException();
                    
            }

            Console.WriteLine("Direction Changed on Left Spin:" + directionLeft);
        }

       public void SpinRight()
        {
            string directionRight = string.Empty;
            switch (direction.ToUpper())
            {
                case "N":
                    directionRight = "E";
                    break;
                case "E":
                    directionRight = "S";
                    break;
                case "S":
                    directionRight = "W";
                    break;
                case "W":
                    directionRight = "N";
                    break;
                default:
                    throw new ArgumentException();

            }

            Console.WriteLine("Direction Changed on Right Spin:" + directionRight);
        }

       public void StepForward()
        {
            switch (direction.ToUpper())
            {
                case "N":
                    y1 += 1;
                    break;
                case "E":
                    x1 += 1;
                    break;
                case "S":
                    y1 -= 1;
                    break;
                case "W":
                    x1 -= 1;
                    break;
                default:
                    throw new ArgumentException();

            }

            Console.WriteLine("Robot direction:" + direction.ToUpper() + " X Position:" + x1 + " Y Position:" + y1);
        }

        public void Move()
        {
            char[] instructions = _roverCommands.ToCharArray();
            //loop through array for each letter, call SpinLeft, SpinRight or SpinForward as appropriate

            for(int i=0; i<instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentException();
                }

            }

        }
    }
}
