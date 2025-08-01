# Devoteam.Demotask

This program creates a room and a robot that can move inside the room.

## Overview

The project consists of two objects, Room and Robot, and an Action controller.

### Room

The room is a square with a width and depth
| . | . | . | . |
|---|---|---|---|
| . | . | . | . |
| . | . | . | . |

This room is 4 squares wide and 3 squares deep. 

Upper left square is (0, 0) and lower right is square (3, 2). 

The room has one method to decide if a given point is inside the room.

### Robot
The robot has one method to perform a move action (Turn left, turn right or move one step forward) and properties for its current position. 
The constructor sets the starting square and the direction. 

| . | . | . | . |
|---|---|---|---|
| . | . | ^ | . |
| . | . | . | . |

This robot is in square (2,1) and is facing north.

### Action controller

The controller interprets a string input and moves the robot.
 * **L** *Turn left*
 * **R** *Turn right*
 * **F** *Walk forward*

For example:

If the current position of the robot is (2,1) facing noth:

| .  | .  | .  |
|--- |--- |--- |
| .  | .  | ^  |

and the controller receives the string ```LF``` the robot turns to the left and moves one step forward, reaching position (1,1) facing west:

| .  | .  | .  |
|--- |--- |--- |
| .  | <  | .  |

Leaving the room is not allowed and will generate an exception.

## Usage

### Build

Open a command window in the directory of the sln-file and type

    dotnet build

### Run
* Start the program ```Devoteam.Demotask.exe``` under the bin folder.
* Input size for a room : two positive integers separated by a space.
* Input starting position for robot: two integers greater than 0 and a letter for the direction (N, E, S or W). Starting position should be inside the room.
* Input a string with move commands: (L, R or F). 

Example:

    Devoteam.Demotask.exe
    5 5
    1 2 N
    RFRFFRFRF

Then the current position is shown in the form:

     Report: 1 3 N

### Run tests

Open a command window in the directory of the sln-file and type

    dotnet test

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[GNU GPLv3](https://www.gnu.org/licenses/gpl-3.0.html)
