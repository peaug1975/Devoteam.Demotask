using Devoteam.Demotask.Exceptions;
using Devoteam.Demotask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoteam.Demotask.Utils
{
    public class StringInputParser
    {
        public SquareRoom SquareRoomFromString(string? input)
        {
            if (string.IsNullOrEmpty(input)) throw new ParserException("Room input cannot be empty");
            var inputs = input.Split(' ');
            if (inputs.Length != 2) throw new ParserException("Room input must be two values separated by a space");
            int width = -1;
            if (!int.TryParse(inputs[0], out width)) throw new ParserException("Room width is not an integer");
            if (width < 1) throw new ParserException("Room width must be grater than zero");
            int depth = -1;
            if (!int.TryParse(inputs[1], out depth)) throw new ParserException("Room depth is not an integer");
            if (depth < 1) throw new ParserException("Room depth must be grater than zero");
            return new SquareRoom(width, depth);
        }
        public Robot RobotFromString(string? input)
        {
            if (string.IsNullOrEmpty(input)) throw new ParserException("Robot input cannot be empty");
            var inputs = input.Split(' ');
            if (inputs.Length != 3) throw new ParserException("Robot input must be three values separated by spaces");
            int x = -1;
            if (!int.TryParse(inputs[0], out x)) throw new ParserException("Robot x position is not an integer");
            if (x < 0) throw new ParserException("Robot x position cannot be negative");
            int y = -1;
            if (!int.TryParse(inputs[1], out y)) throw new ParserException("Robot y position is not an integer");
            if (x < 0) throw new ParserException("Robot y position cannot be negative");
            Direction dir = EnumHelper.DirectionFromString(inputs[2]);
            
            return new Robot(x,y,dir);
        }
    }
}
