﻿
namespace DesignPatterns.Labyrinth
{
    /// <summary>
    /// Builder pattern
    /// </summary>
    public abstract class MazeBuilder
    {
        public abstract void BuildMaze();
        public abstract void BuilRoom(int roomNo);
        public abstract void BuildDoor(int roomNo1, int roomNo2);
        public abstract Maze GetMaze();
    }
}
