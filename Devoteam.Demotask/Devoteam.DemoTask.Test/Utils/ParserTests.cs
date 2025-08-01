using Devoteam.Demotask.Exceptions;
using Devoteam.Demotask.Model;
using Devoteam.Demotask.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoteam.DemoTask.Test.Utils
{
    public class ParserTests
    {
        [Fact]
        public void RoomParserInputOkTest()
        {
            StringInputParser parser = new StringInputParser();
            var room = parser.SquareRoomFromString("2 3");
        }

        [Theory]
        [InlineData("")]
        [InlineData("1")]
        [InlineData("1 2 3")]
        [InlineData("a 1")]
        [InlineData("0 1")]
        public void RoomParserInputNotOkTest(string notOkInput)
        {
            StringInputParser parser = new StringInputParser();
            foreach (var notOk in notOkInput)
            {
                Assert.Throws<ParserException>(() => parser.SquareRoomFromString(notOkInput));
            }
        }

        [Fact]
        public void RobotParserInputOkTest()
        {
            StringInputParser parser = new StringInputParser();
            var robot = parser.RobotFromString("0 1 N");
            Assert.Equal(0, robot.X);
            Assert.Equal(1, robot.Y);
            Assert.Equal(Direction.North, robot.Dir);
        }

        [Theory]
        [InlineData("")]
        [InlineData("1")]
        [InlineData("1 2")]
        [InlineData("x 1 N")]
        [InlineData("0 x N")]
        [InlineData("-1 0 N")]
        [InlineData("0 -1, N")]
        [InlineData("1 1 X")]
        public void RobotParserInputNotOkTest(string notOkInput)
        {
            var room = new SquareRoom(2, 2);
            StringInputParser parser = new StringInputParser();
            foreach (var notOk in notOkInput)
            {
                Assert.Throws<ParserException>(() => parser.RobotFromString(notOkInput));
            }
        }
    }
}
