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
        [Theory]
        [InlineData("RFRFFRFRF", 1, 3, Direction.North, 1, 2, Direction.North)]
        [InlineData("RFLFFLRF", 3, 1, Direction.East, 0, 0, Direction.East)]
        public void MoveRobotInsideRoomTest(string moveSequence, int expectedX, int expectedY, Direction expectedDir, int startX, int startY, Direction startDir)
        {
            var room = new SquareRoom(5, 5);
            var robot = new Robot(startX, startY, startDir);
            var mover = new RobotMover();
            mover.MoveRobotInRoomFromString(robot, room, moveSequence);
            Assert.Equal(expectedX, robot.X);
            Assert.Equal(expectedY, robot.Y);
            Assert.Equal(expectedDir, robot.Dir);
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
            var robot = new Robot(0, 2, Direction.East);
            var mover = new RobotMover();
            mover.MoveRobotInRoomFromString(robot, room, "FFFF");
            Assert.Throws<BusinessException>(() => mover.MoveRobotInRoomFromString(robot, room, "F"));
        }
    }
}
