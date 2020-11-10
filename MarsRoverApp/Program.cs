using System;

namespace MarsRoverApp
{
    //Rover: Position and Location =>(x,y,z) where z in {N, E, W, S}
    //Plateau: Grid of positions => (x,y,z) where (0,0,N) => {x=0, y=0, z=N}
    //Message: (mmmmmmm) => m in {L, R, M} => {L= SpinLeft, R=Spinright, M=StepForward}
    //Input:
    //RoverPosition (first line)
    //RoverCommand (second line)
    //Rover should spin left
    //Rover should spin right
    //Rover should move forward
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plateau surface size :");
            var sizeInput = Console.ReadLine(); 

            Console.WriteLine("Rover position - Enter x, y postion and direction in the format 1 2 N:");
            string roverPositionInput = Console.ReadLine();

            Console.WriteLine("Rover command - Enter command in string Format e.g. MMRRMMR :");
            var roverCommandInput = Console.ReadLine();

            Robot robot = new Robot(roverPositionInput, roverCommandInput);
            Console.WriteLine("Expected Output :");
            Console.WriteLine("Spin Left:");
            robot.SpinLeft();
            Console.WriteLine("Spin Right:");
            robot.SpinRight();
            Console.WriteLine("Step forward:");
            robot.StepForward();
            Console.WriteLine("Move Robot:");
            robot.Move();
            
        }
    }
}
