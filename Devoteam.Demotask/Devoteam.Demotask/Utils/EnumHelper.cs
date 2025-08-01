using Devoteam.Demotask.Exceptions;
using Devoteam.Demotask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devoteam.Demotask.Utils
{
    static class EnumHelper
    {
        public static Direction DirectionFromString(string input)
        {
            switch (input)
            {
                case "N": return Direction.North;
                case "E": return Direction.East;
                case "S": return Direction.South;
                case "W": return Direction.West;
                default: throw new ParserException(input + " is not valid direction for robot");
            }
        }
        public static string StringFromDirection(Direction input)
        {
            switch (input)
            {
                case Direction.North: return "N";
                case Direction.East: return "E";
                case Direction.South: return "S";
                case Direction.West: return "W";
                default: throw new ParserException("Direction " + input + " is not mapped");
            }
        }
    }
}
