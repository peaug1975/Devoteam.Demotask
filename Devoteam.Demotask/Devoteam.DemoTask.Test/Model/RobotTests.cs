using Devoteam.Demotask.Model;
namespace Devoteam.DemoTask.Test.Model
{
    public class RobotTests
    {
        [Fact]
        public void MoveRobotInCircle()
        {
            Robot r = new Robot(1, 1, Direction.North);
            r.Move(MoveAction.Forward);
            r.Move(MoveAction.Right);
            r.Move(MoveAction.Forward);
            r.Move(MoveAction.Right);
            r.Move(MoveAction.Forward);
            r.Move(MoveAction.Right);
            r.Move(MoveAction.Forward);
            r.Move(MoveAction.Right);
            r.Move(MoveAction.Left);
            r.Move(MoveAction.Left);
            r.Move(MoveAction.Left);
            r.Move(MoveAction.Left);
            Assert.Equal(1, r.X);
            Assert.Equal(1, r.Y);
            Assert.Equal(Direction.North, r.Dir);
        }
    }
}