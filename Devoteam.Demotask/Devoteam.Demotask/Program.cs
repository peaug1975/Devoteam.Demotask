using Devoteam.Demotask.Exceptions;
using Devoteam.Demotask.Logic;
using Devoteam.Demotask.Model;
using Devoteam.Demotask.Utils;

namespace Devoteam.Demotask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var parser = new StringInputParser();
                Console.WriteLine("Enter room width and depth");
                var roomInput = Console.ReadLine();
                var room = parser.SquareRoomFromString(roomInput);
                Console.WriteLine("Enter robot position and direction");
                var robotInput = Console.ReadLine();
                var robot = parser.RobotFromString(robotInput);
                if (!room.IsInside(robot.X, robot.Y))
                {
                    throw new BusinessException("Robot is not starting inside room");
                }
                Console.WriteLine("Enter move sequence");
                var moveInput = Console.ReadLine();
                if (string.IsNullOrEmpty(moveInput))
                {
                    throw new ParserException("Move sequence cannot be empty");
                }
                var mover = new RobotMover();
                mover.MoveRobotInRoomFromString(robot, room, moveInput);
                Console.WriteLine($"Report: {robot.X} {robot.Y} {EnumHelper.StringFromDirection(robot.Dir)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Program exited with an error: " + e.Message);
            }
        }

    }
}
