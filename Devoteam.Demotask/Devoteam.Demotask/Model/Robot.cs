using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoteam.Demotask.Model
{
    public enum Direction { East, South, West, North };
    public enum MoveAction { Forward, Left, Right };
    public class Robot(int startX, int startY, Direction startDir)
    {
        private int posX = startX;
        private int posY = startY;
        private Direction dir = startDir;

        public int X { get { return posX; } }
        public int Y { get { return posY; } }
        public Direction Dir { get { return dir; } }

        public void Move(MoveAction act)
        {
            switch (act)
            {
                case MoveAction.Forward:
                    switch (dir)
                    {
                        case Direction.North: posY--; break;
                        case Direction.South: posY++; break;
                        case Direction.East: posX++; break;
                        case Direction.West: posX--; break;
                    }
                    break;
                case MoveAction.Right:
                    switch (dir)
                    {
                        case Direction.North: dir = Direction.East; break;
                        case Direction.East: dir = Direction.South; break;
                        case Direction.South: dir = Direction.West; break;
                        case Direction.West: dir = Direction.North; break;
                    }
                    break;
                case MoveAction.Left:
                    switch (dir)
                    {
                        case Direction.North: dir = Direction.West; break;
                        case Direction.West: dir = Direction.South; break;
                        case Direction.South: dir = Direction.East; break;
                        case Direction.East: dir = Direction.North; break;
                    }
                    break;
            }
        }
    }
}
