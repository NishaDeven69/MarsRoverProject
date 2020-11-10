using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverApp
{
   public interface IRobot
    {
        int x { get; }
        int y { get; }
        public string direction { get; }
        public string roverCommands { get; }

        void SpinLeft();
        void SpinRight();
        void StepForward();
        void Move();

    }
}
