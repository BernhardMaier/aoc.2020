﻿using System.Linq;
using System.Reflection;
using static System.Console;

string output = $"## The answers for {Assembly.GetCallingAssembly().GetName().Name.Replace('_', ' ')} are {GetAnswer1()} and {GetAnswer2()} ##";
WriteLine(new string('#', output.Length));
WriteLine(output);
WriteLine(new string('#', output.Length));

/// <summary>
/// Gets the answer for the first question of a day
/// </summary>
/// <returns></returns>
int GetAnswer1()
{
    string[] input = GetInput();
    int result = 0;

    //TODO

    return result;
}

/// <summary>
/// Gets the answer for the second question of a day
/// </summary>
/// <returns></returns>
int GetAnswer2()
{
    string[] input = GetInput();
    int result = 0;

    //TODO

    return result;
}

/// <summary>
/// Provides the input for the current day
/// </summary>
string[] GetInput()
{
    return new string[]
    {
        "......#...........#...#........",
        ".#.....#...##.......#.....##...",
        "......#.#....#.................",
        "..............#.#.......#......",
        ".....#.#...##...#.#..#..#..#..#",
        ".......##...#..#...........#...",
        ".......#.##.#...#.#.........#..",
        "..#...##............##......#.#",
        ".......#.......##......##.##.#.",
        "...#...#........#....#........#",
        "#............###.#......#.....#",
        "..#........#....#..#..........#",
        "..#..##....#......#..#......#..",
        "........#......#......#..#..#..",
        "..#...#....#..##.......#.#.....",
        ".....#.#......#..#....#.##.#..#",
        "......###.....#..#..........#..",
        ".#................#.#..........",
        ".........#..#...#......##......",
        "##...#....#...#.#...#.##..#....",
        "...##...#....#.........###.....",
        ".#.#....#.........##...........",
        "....#.#..#..#...........#......",
        "..#..#.#....#....#...#.........",
        "..........##.....#.##..........",
        "..#.#....#..##......#.#.....##.",
        "..#...#.##......#..........#...",
        "......#....#..#.....#.....#...#",
        "#.#...##.#.##.........#..#.....",
        "...#.#.#.........#.....#.#.#...",
        "..#.........#...............#..",
        "#..##.....#.........#....#.....",
        "...#....##..##...........##..#.",
        "......##.................#.#...",
        "##.......#....#.#.#.....#......",
        "....#.#...#.................##.",
        "#...#.........##.....#.........",
        "#....#.###..#.....##.#....#....",
        "#..#....#...#....#.#.#.........",
        ".......#...........#....#.....#",
        "#...#.............#........#...",
        ".......#.....#...#..#.........#",
        ".##.....##.....##.......#......",
        "....##...##.......#..#.#.....#.",
        ".##.........#......#........##.",
        ".......#...#...###.#..#........",
        "..#..###......##..##...........",
        ".#..#......##..#.#.........#...",
        "...#.......#........#...#.#....",
        "...#....#..#....#.....##.......",
        "............#......#..........#",
        ".#.......#......#.#....#..#.#..",
        "##.........#.#.#..........#....",
        "....##.....#...................",
        ".......#..#........#...........",
        "....##.#..#......###.......#...",
        "....#....#...#.#......#...#...#",
        ".......#.....##..#....#...#....",
        "#...#........#.........#..##...",
        "...........##.........#.#...#..",
        "....................#....#.##..",
        ".#..#..#.........#....#..#..##.",
        "......................#........",
        "..###....#.......#.....###.##..",
        "......#......#.......#.....#..#",
        ".....#...#.##...#......#....#..",
        ".....#.....##.............#....",
        "....#......##..#....#.......#..",
        ".##....#..##......###....#..#..",
        "...###.#.............##...#.#..",
        ".....#.....#.....#...#..#.#....",
        "..#.#.....###......#.......#...",
        "..........#.##......#.........#",
        "..##..#.......................#",
        "........#......#............#..",
        "#..#..#..#.#......#..#....#....",
        "...##......#.............#....#",
        "...........#..#..##.......#....",
        ".....#.........#.#..#..........",
        "##...#.......#.#....#..#..#....",
        "#.#.#...........#.##.#.#..###..",
        "#..#...........#.........##....",
        "............#.#..............#.",
        ".#....#....##.#...........#..#.",
        "....#...#..#...#....#....#.....",
        "....#....#...#..#......#.......",
        ".#.#.........#.......#.##......",
        ".#..##...#........#...........#",
        "##...#..#...#...#.....#...#....",
        "....###.#..#.......##.#..#...#.",
        "...##.......####...##.#........",
        "#....#....#.#............#..#..",
        "#.#.#...#...................##.",
        "##......#...........#..........",
        "#..#..#....#.#...#......#......",
        ".##...#.....#...#........#.....",
        "..#............#..............#",
        "###........#..#....#...#......#",
        "###..##......#.##...........#..",
        "........#......#..#.....#......",
        "...#..........#..#...........#.",
        "....#..#..#....#........#....#.",
        ".#.................#####..##..#",
        ".....#...##..#..........#.##...",
        "..#..............#...####......",
        ".....#.##..................#.#.",
        "...#.#..#..#........#..........",
        "...........#....#.#..#.........",
        ".....##.......#......#..#.#.#..",
        "...#.............##...#........",
        "...............#.......##.##.##",
        ".....#........#........#.#..#..",
        "...#..#.........#...##...###...",
        "...#.#.............###.#.....#.",
        ".#..........#......###.#.#.....",
        "....##..##.............###.....",
        "..#..#.#...##...#.......##.....",
        "..........###........#.....#.#.",
        "#.#....#..#..#......#...#...#..",
        ".........#......##.......#.#..#",
        "...#.....#.........##..#..#....",
        ".....##.#..##.##..##...........",
        "...#.#.##....#..#..#......#..#.",
        "#....#....#.............#...##.",
        "#......#..#.####.#.##.#....##..",
        "##.#.#....##..................#",
        ".....##......#.......##.......#",
        "..#......#.#..#...##......##...",
        "..#....##....#.........#..##...",
        ".###.....#....##...........#...",
        ".........#......#.#........#...",
        "...#...#..#.#....######.#..#...",
        "###......#.#.#.........##.#....",
        ".....#...#.........#...#.......",
        "....#.............#.#.........#",
        "..##...#...#.......#......#....",
        ".....#...#.#...#...#..#........",
        ".#......#......................",
        "...###..#..#....#...##.#.......",
        ".#.#.....##...#...#.....#...##.",
        ".....###..###....##............",
        ".....##....#..#.....#.##.......",
        "#........#.........#...#..#....",
        "...#.#.........#..#.......#.#..",
        "....#.#....##.....#..........#.",
        ".#..#....#..#.#..#..#.........#",
        "#...#....#..............#......",
        ".........#.....#.##...##...###.",
        ".....#....##............#..#...",
        ".....#.#...........#..#....#...",
        ".#..........#...#......#.....#.",
        ".#...........#.....#..#........",
        "..............#......##...#..#.",
        "...#.........#..#....#..##...##",
        "..##...#..................#....",
        "#.....#.................#......",
        "...#......#..#..........#.#....",
        "......#..#.....#.....##...#..#.",
        "......#........#..........#....",
        "...##.##....#..##.#..........#.",
        "..........#..#.#.##............",
        "..##........................#..",
        ".....#.#.#......#....#....##...",
        "#....#.........#........#......",
        ".##.......#...#...#........##..",
        "....##......#....#.#..........#",
        "..#.......#..............#.....",
        ".....#......#.#...#..#.#.#....#",
        ".....#..#........#.##.##.......",
        "##........#..........#.........",
        ".....#..##....#.#......###..##.",
        "#.#...##.........#.#.....#..#..",
        "#....#.#...#........#.....#..#.",
        "........................#......",
        "....###......#............#...#",
        "...#..##......#..##.........#..",
        ".............#...#......#..#..#",
        "....#......#....#...........#..",
        "..#.#.####.#.....##........#..#",
        "#..#...#..#..#.......#.#..#....",
        "..#..#..#....#.#.........##..#.",
        ".......#......#.#............#.",
        "...#.............#.#.....#.....",
        "...#.#.........##...#.#.......#",
        "........#...#...........##...#.",
        "..........#....#......#....##..",
        "..........#...........#........",
        "...#..#...#..........#......#..",
        "......#......#....#.....#..#.#.",
        "........##.................#..#",
        ".#........#.#...........#......",
        "#...#........#.#.#.....#.#.#...",
        ".........#........#..#..#....#.",
        "##........#..........#....#..#.",
        ".#.##...........#..#.#..##....#",
        ".......#.#....#..#......#......",
        "..#.....#........##..#......###",
        "..#...#..................#....#",
        "......#...#..#.##.......#......",
        "........#...#.#................",
        ".........#............#........",
        "..#.....##....#.#..##..........",
        "#.....#..........#....#........",
        "....#.#...#...##....#.....##...",
        "..#.#.......#.............#...#",
        "...##..............#......#....",
        "#......#...#................##.",
        ".#.#...#.#..#..................",
        "...##.......#...........#.#.#..",
        "#......#.#.#........#.##...####",
        ".......#..#.#.........#.#.##..#",
        "..............#....#.........#.",
        "...........#.#..#....##......#.",
        "#.............#...##..#.......#",
        ".........#............#...#.##.",
        ".......#.........#.#.....#..#..",
        "........................#.#.##.",
        "#......#.#......#.........#....",
        "...#.......#.......#.....#.....",
        "#..#....#................#...#.",
        "........#.#..##......#.........",
        "#..#...##....##....##.........#",
        ".......#...#...###.............",
        "#.#..#........#.#.#............",
        "#.....#........##.........#.#..",
        ".#..........#....#.#....###....",
        ".#.....#...#.#........#..#.##..",
        "...#.##......#..#.............#",
        "..##..#.#...................#..",
        ".....#....#...#.#...#...#......",
        ".....#..#.#....#.#.............",
        "#.#....#.#.##..###..........#..",
        "........#.#.............#..#...",
        ".........#.......#.............",
        ".##.#............##...#........",
        "......#................#.......",
        "...............#..#...........#",
        "...#.......#...#.##.....#....#.",
        "##..##..#..........#...........",
        ".##.#.......#...#..#...#...#...",
        "....#..#...........#....#.##...",
        ".#........#........#....#......",
        ".......#...#.##.#..#.#..#......",
        ".#..#......#....#...##....#.#..",
        "......#...##.#.....##.###.....#",
        ".#....#..#......#...#.#.....#..",
        "#............#....##...##.##...",
        "#...#.#....#...#.......##...##.",
        "#...........#.##..#....#.....#.",
        "...#..#...#.........#.......#..",
        ".#....#.....#............#.#..#",
        ".#.....#.#...#.#....##......###",
        "..#..#.#.#...#..#.............#",
        "...#...#..#....#........#...##.",
        ".......#.....#...##...........#",
        "#.##.................#...##...#",
        "..............##........#.....#",
        "............#...#..#.......#.#.",
        "#.#.....#.........#...#......#.",
        "#.###..#......#..#..#...#.....#",
        ".....#.......#.................",
        "........#..#......#.#...#......",
        "#.......#..#........#...#..#...",
        "..#...#.......##.............#.",
        "#.......#.......##...#.........",
        ".........#....#.#..##.....#...#",
        "..#.....#.#.......#....#.......",
        "...#.......#.....#..##.#..#....",
        "....#.......#.#.#..............",
        ".#..#......#........#.#..##..##",
        "....#...#.##.#...#....##...#...",
        "#..##..#.....#.......#.........",
        "....#..#..#.#............#.....",
        "#.......##...##..##............",
        "...............................",
        "....#.......#.##...#.....#.#...",
        "...#........#....#.#..#..#.....",
        "##.......#.....##.#.#....#....#",
        "#.............#...........#.##.",
        "#...........#.#..........#.....",
        "#..#....#....#.#.........#.#...",
        "......#.#.#..#.#.#.............",
        "...#.....#........##....#......",
        "..#...#...#.#.......#......#...",
        ".##........#...#..#..........#.",
        "..#...........#..##.....##.....",
        "............#..#.#...#.....#...",
        "..........#....##.......#......",
        "....#....#.................#..#",
        "....#...............#.........#",
        "..#.#...#......#..........##...",
        ".....#...........#.........#..#",
        ".......#.....##.....#.#........",
        ".#.#..........#....#...........",
        ".#..##....#........#....#......",
        "....#.#..#.......#..#.........#",
        "..#....#.....#......#..#.......",
        "......#........#.......#...#.#.",
        ".......#.......#....#.....##...",
        "....##........#..#...#.#..#...#",
        ".#......#...........##....#....",
        "##....##......#.......#.......#",
        ".##....#.##......#.......##..#.",
        "...#..#.#.#.......#..#.###.....",
        "..........##....#..#.##........",
        "...#........###.#..#........#..",
        ".....#....#..##....#.....#....#",
        "#..........#..........#.#....#.",
        "..#....#.....#..............#..",
        "#..................#......#.##.",
        ".#...#.#.....#.........##......",
        "...#...........#.....#......#..",
        "......#.....#.#..##......##....",
        "...#....###..#.....#..#..##..##",
        "......#.......##..#..#.........",
        "#..#.#....#.#..#..........##.#.",
        "..#..#..##..#.#.#.#.....#......",
        "..#.#...#..#.....###.#.........",
        "##.#.#......#........#.####....",
        ".............#..#..#....#......",
        "...##..........#.......#.#....#",
        "..#.....................#......",
        "..#..#...##...#.##........#...."
    };
}