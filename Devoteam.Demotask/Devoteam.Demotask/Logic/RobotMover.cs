using Devoteam.Demotask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoteam.Demotask.Logic
{
    public class RobotMover
    {
        public void MoveRobotInRoomFromString(Robot robot, SquareRoom room, string moveSequence)
        {
            foreach (char c in moveSequence)
            {
                switch (c)
                {
                    case 'F': robot.Move(MoveAction.Forward); break;
                    case 'L': robot.Move(MoveAction.Left); break;
                    case 'R': robot.Move(MoveAction.Right); break;
                    default: throw new Exception("Not valid move");
                }
                if (!room.IsInside(robot.X, robot.Y))
                    throw new Exception("Robot walked outside room");
            }
        }
    }
}
