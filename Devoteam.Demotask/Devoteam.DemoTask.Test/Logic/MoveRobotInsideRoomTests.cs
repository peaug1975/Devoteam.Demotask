using Devoteam.Demotask.Exceptions;
using Devoteam.Demotask.Logic;
using Devoteam.Demotask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoteam.DemoTask.Test.Logic
{
    public class MoveRobotInsideRoomTests
    {
        [Fact]
        public void MoveRobotInsideRoomTest()
        {
            var room = new SquareRoom(5, 5);
            var robot = new Robot(1, 2, Direction.North);
            var mover = new RobotMover();
            mover.MoveRobotInRoomFromString(robot, room, "RFRFFRFRF");
            Assert.Equal(1, robot.X);
            Assert.Equal(3, robot.Y);
            Assert.Equal(Direction.North, robot.Dir);
        }
        [Fact]
        public void MoveRobotWithWrongInputTest()
        {
            var room = new SquareRoom(5, 5);
            var robot = new Robot(1, 2, Direction.North);
            var mover = new RobotMover();
            Assert.Throws<ParserException>(() => mover.MoveRobotInRoomFromString(robot, room, "X"));
        }

        [Fact]
        public void ExitRoomTest()
        {
            var room = new SquareRoom(5, 5);
            var robot = new Robot(1, 2, Direction.East);
            var mover = new RobotMover();
            mover.MoveRobotInRoomFromString(robot, room, "FFFF");
            Assert.Throws<BusinessException>(() => mover.MoveRobotInRoomFromString(robot, room, "F"));
        }
    }
}
