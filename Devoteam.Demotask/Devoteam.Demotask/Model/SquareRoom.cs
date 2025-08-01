using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoteam.Demotask.Model
{
    public class SquareRoom
    {
        public SquareRoom(int width, int depth)
        {
            roomWidth = width;
            roomDepth = depth;
        }
        private int roomWidth { get; set; }
        private int roomDepth { get; set; }
        public bool IsInside(int x, int y)
        {
            return x >= 0
                && y >= 0
                && x < roomWidth 
                && y < roomDepth;
        }
    }
}
