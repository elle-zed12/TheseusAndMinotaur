using System;
using System.Collections.Generic;
using System.Text;

namespace GazelleLowcay_Final_Portfolio.Model
{
    public class Game
    {
        // Fields
        protected Level currentLevel;
        protected List<Level> allLevels = new List<Level>();


        // Properties
        public int LevelCount => allLevels.Count;

        public string CurrentLevelName => allLevels.Count != 0 ? currentLevel.Name : "No levels loaded";

        public int LevelHeight => allLevels.Count != 0 ? currentLevel.Height : 0;

        public int LevelWidth => allLevels.Count != 0 ? currentLevel.Width : 0;

        public Level CurrentLevel => this.currentLevel;

        public int MoveCount => this.currentLevel.GetMoveCount;

        public bool HasMinotaurWon => this.currentLevel.CheckIfMinotaurWon();

        public bool HasTheseusWon => this.currentLevel.CheckIfTheseusWon();

        // Methods
        public void AddLevel(string newName, int newWidth, int newHeight, string newData)
        {
            var newLevel = new Level(newName, newWidth, newHeight, newData);
            this.currentLevel = newLevel;
            this.allLevels.Add(newLevel);
        }

        public List<string> LevelNames()
        {
            var levelNames = new List<string>();
            foreach (Level level in allLevels) 
            {
                levelNames.Add(level.Name);
            }
            return levelNames;
        }

        public void SetLevel(string theLevel) 
        {
            foreach (Level level in allLevels)
            {
                if (level.Name.Equals(theLevel))
                {
                    level.Restart();
                    this.currentLevel = level;                   
                    return;
                }
            }
        }


        public Square WhatIsAt(int x, int y)
        {

            return (Square)this.currentLevel.Maze[x, y];
        }

        public void MoveTheseus((int, int) moves)
        {
            this.currentLevel.TheseusMoves(moves);
        }

        public void MoveMinotaur()
        {
            this.currentLevel.MoveMinotaur();
        }

  
    }
}
