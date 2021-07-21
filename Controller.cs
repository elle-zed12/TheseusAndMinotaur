
using GazelleLowcay_Final_Portfolio.Model;
using GazelleLowcay_Final_Portfolio.Interface;

namespace GazelleLowcay_Final_Portfolio
{
    public class Controller : IMoves
    {        
        protected Game game;        

        public Controller(Game newGame)        
        {
            this.game = newGame;
        }

        public int LevelHeight => game.LevelHeight;

        public int LevelWidth => game.LevelWidth;


        public Square CheckSquare(int x, int y)
        {
            Square square = game.WhatIsAt(x, y);
            return square;
        }

        public Level CurrentLevel()
        {
            return game.CurrentLevel;
        }

        public string SetLevelName()
        {
            string theLevel = $"{game.CurrentLevelName}";
            return theLevel;
        }

        public string SetMoveCount()
        {
            string moveCount = $"Move count: {game.MoveCount}";
            return moveCount;
        }

        //public 

        public void Go()
        {
            this.SetLevel("level 1");
        }

        public void MoveUp()
        {
            game.MoveTheseus(Moves.UP);
            game.MoveMinotaur();
        }

        public void MoveDown()
        {
            game.MoveTheseus(Moves.DOWN);
            game.MoveMinotaur();
        }

        public void MoveRight()
        {
            game.MoveTheseus(Moves.RIGHT);
            game.MoveMinotaur();
        }

        // I tried adding all of the level inside the list, but the data are not returning properly as i retrieve and load the level to display.
        // Must investigate more why.

        //public void AddAllLevels()
        //{
        //    string data = "0001 0201 0103";
        //    data += " 1001 1010 1100 0001";
        //    data += " 0001 1110 0001 1010";
        //    data += " 0011 1010 0110 1011";
        //    game.AddLevel("Level 1", 4, 3, data);

        //    string data1 = "0002 0302 0203";
        //    data1 += " 1001 1010 1000 1000";
        //    data1 += " 0001 1110 0001 0000";
        //    data1 += " 0001 1010 0000 1000";
        //    data1 += " 0011 1010 0010 0010";
        //    game.AddLevel("Level 2", 4, 4, data1);

        //    string data2 = "0002 0302 0304";
        //    data2 += " 1001 1010 1000 1000 0001";
        //    data2 += " 0001 1110 0001 0000 1010";
        //    data2 += " 0001 1010 0000 0000 1010";
        //    data2 += " 0011 1010 0010 0010 1010";
        //    game.AddLevel("Level 3", 5, 4, data2);

        //    string data3 = "0002 0302 0204";
        //    data3 += " 1001 1010 1000 1000 0001";
        //    data3 += " 0001 1110 0001 0000 1010";
        //    data3 += " 0001 1010 0000 0000 1010";
        //    data3 += " 0001 1010 0000 0000 1010";
        //    data3 += " 0011 1010 0010 0010 1010";
        //    game.AddLevel("Level 4", 5, 5, data3);

        //    string data4 = "0001 0201 0103";
        //    data4 += " 1001 1010 1100 0001";
        //    data4 += " 0001 1110 0001 1010";
        //    data4 += " 0011 1010 0110 1011";
        //    game.AddLevel("Level 5", 4, 3, data4);
        //}


        public void SetLevel(string level)
        {
            switch (level)
            {
                case "level 1":
                    {
                        string data = "0001 0201 0103";
                        data += " 1001 1010 1100 0001";
                        data += " 0001 1110 0001 1010";
                        data += " 0011 1010 0110 1011";
                        game.AddLevel("Level 1", 4, 3, data);
                        break;
                    }
                case "level 2":
                    {
                        string data1 = "0302 0001 0203";
                        data1 += " 1001 1010 1000 1000";
                        data1 += " 0001 1110 0001 0000";
                        data1 += " 0001 1010 0000 1000";
                        data1 += " 0011 1010 0010 0010";
                        game.AddLevel("Level 2", 4, 4, data1);
                        break;
                    }
                case "level 3":
                    {
                        string data2 = "0002 0302 0304";
                        data2 += " 1001 1010 1000 1000 0001";
                        data2 += " 0001 1110 0001 0000 1010";
                        data2 += " 0001 1010 0000 0000 1010";
                        data2 += " 0011 1010 0010 0010 1010";
                        game.AddLevel("Level 3", 5, 4, data2);
                        break;
                    }
                case "level 4":
                    {
                        string data3 = "0000 0402 0204";
                        data3 += " 1001 1010 1000 1000 0001";
                        data3 += " 0001 1110 0001 0000 1010";
                        data3 += " 0001 1010 0000 0000 1010";
                        data3 += " 0001 1010 0000 0000 1010";
                        data3 += " 0011 1010 0010 0010 1010";
                        game.AddLevel("Level 4", 5, 5, data3);
                        break;
                    }
                case "level 5":
                    {
                        string data3 = "0001 0300 0004";
                        data3 += " 1001 1010 1000 1000 1000 0001";
                        data3 += " 0001 1110 0001 0000 0000 1010";
                        data3 += " 0001 1010 0000 0000 0000 1010";
                        data3 += " 0001 1010 0000 0000 0000 1010";
                        data3 += " 0011 1010 0010 0010 0010 1010";
                        game.AddLevel("Level 5", 6, 5, data3);
                        break;
                    }

            }
        }
        public void MoveLeft()
        {
            game.MoveTheseus(Moves.LEFT);
            game.MoveMinotaur();
        }

        public void Pause()
        {
            game.MoveTheseus(Moves.PAUSE);
            game.MoveMinotaur();
        }


        public bool HasMinotaurWon()
        {
            return game.HasMinotaurWon;
        }

        public bool HasTheseusWon()
        {
            return game.HasTheseusWon;
        }

        public void MoveMinotaur()
        {
            game.MoveMinotaur();
        }


    }


}
