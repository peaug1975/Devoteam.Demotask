using Devoteam.Demotask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoteam.DemoTask.Test.Model
{
    public class RoomTests
    {
        [Fact]
        public void InsideRoomTest()
        {
            var room = new SquareRoom(2, 4);

            //Inside
            Assert.True(room.IsInside(0, 0));
            Assert.True(room.IsInside(1, 3));

            //Outside
            Assert.False(room.IsInside(0, -1));
            Assert.False(room.IsInside(-1, 0));
            Assert.False(room.IsInside(3, 3));
            Assert.False(room.IsInside(1, 5));
        }
    }
}
