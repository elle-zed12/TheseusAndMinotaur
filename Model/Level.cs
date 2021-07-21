using System;
using System.Collections.Generic;
using System.Text;

namespace  GazelleLowcay_Final_Portfolio.Model
{
    public class Level
    {
        protected string levelName;
        protected string data;
        protected int width = 0;
        protected int height = 0;
        protected MazeItem[,] maze;
        protected Minotaur theMinotaur;
        protected Theseus theTheseus;
        protected Exit theExit;
        protected int moveCount = 0;
        protected bool hasMinotaurWon = false;
        protected bool hasTheseusWon = false;

        public Level(string newName, int newWidth, int newHeight, string newData)
        {
            this.levelName = newName;
            this.height = newHeight;
            this.width = newWidth;
            this.data = newData;
            this.maze = new MazeItem[newHeight, newWidth];
            this.CreateMaze();
            this.PlaceMazeCharacter();
            // this has to be restart, encountering problem when changing level without restarting the model
        }

        public void Restart() {
            this.moveCount = 0;
            this.CreateMaze();
            this.PlaceMazeCharacter();
        }

        public int Height => this.height;

        public int Width => this.width;

        public string Name
        {
            get { return this.levelName; }
            set
            {
                levelName = value;
            }
        }

        public bool HasMinotaurWon => this.hasMinotaurWon;

        public bool HasTheseusWon => this.hasTheseusWon;

        public int GetMoveCount => this.moveCount;

        public Theseus TheTheseus => this.theTheseus;

        public MazeItem[,] Maze => this.maze;        

        // Extract the data for the Maze
        public void CreateMaze()
        {
            int x = 0;
            int y = 0;
            for (int i = 15; i < data.Length; i += 5)
            {
                bool top = data.Substring(i, 1).Equals("1");
                bool right = data.Substring(i + 1, 1).Equals("1");
                bool bottom = data.Substring(i + 2, 1).Equals("1");
                bool left = data.Substring(i + 3, 1).Equals("1");

                Square newSquare = new Square(x, y, top, right, bottom, left);
                this.maze[x, y] = newSquare;

                if (y < width && x < height)
                {
                    y++;
                }
                if (y == width && x < height)
                {
                    x++;
                    y = 0;
                }
            }

        }

        public void SetMoveCount(ref int count)
        {
            moveCount += count;
        }

        public void TheseusMoves((int, int) moveDirection)
        {
            
            Position whereIsTheseus = theTheseus.CurrentPosition();
            Position movingTheseus = theTheseus.Move(moveDirection, theTheseus.CurrentPosition());
            var aSquare = this.GetSquare(whereIsTheseus.X, whereIsTheseus.Y);
            var destinationSquare = this.GetSquare(movingTheseus.X, movingTheseus.Y);
            bool isBlocked = this.IsBlocked(aSquare, destinationSquare, moveDirection);
            if (isBlocked)
            {
                // If move direction is Pause increase moveCount 
                if (moveDirection.Equals(Moves.PAUSE))
                {
                    int count = this.moveCount;
                    SetMoveCount(ref count);
                }
                return;
            }
            aSquare.RemoveTheseus();
            destinationSquare.AddTheseus();
            theTheseus.Update = new Position(movingTheseus.X, movingTheseus.Y);
            this.moveCount++;
        }




        public void MoveMinotaur()
        {
            Position whereIsTheseus = theTheseus.CurrentPosition();
            Position whereIsMinotaur = theMinotaur.CurrentPosition();
            // Position moving Minotaur;
            var currentSquare = this.GetSquare(whereIsMinotaur.X, whereIsMinotaur.Y);
            bool isBlocked = false;
            if (whereIsTheseus.X < whereIsMinotaur.X && whereIsTheseus.Y.Equals(whereIsMinotaur.Y) )
            {
                var moveDirection = Moves.UP;
                MoveMinotaur(whereIsMinotaur, currentSquare, moveDirection);
                return;
            }
            // If thesues below minoatur
            if (whereIsTheseus.X > whereIsMinotaur.X && whereIsTheseus.Y.Equals(whereIsMinotaur.Y))
            {
                var moveDirection = Moves.DOWN;
                MoveMinotaur(whereIsMinotaur, currentSquare, moveDirection);
                return;
            }

            if (whereIsTheseus.Y > whereIsMinotaur.Y)
            { 
                Position movingMinotaur = theMinotaur.Move(Moves.RIGHT, whereIsMinotaur);
                var destinationSquare = this.GetSquare(movingMinotaur.X, movingMinotaur.Y);
                isBlocked = this.IsBlocked(currentSquare, destinationSquare, Moves.RIGHT);
                if (!isBlocked)
                {
                    currentSquare.RemoveMinotaur();
                    destinationSquare.AddMinotaur();
                    theMinotaur.Update = new Position(movingMinotaur.X, movingMinotaur.Y);
                    return;
                }
            }
            else if (whereIsTheseus.Y < whereIsMinotaur.Y)
            {
                Position movingMinotaur = theMinotaur.Move(Moves.LEFT, whereIsMinotaur);
                var destinationSquare = this.GetSquare(movingMinotaur.X, movingMinotaur.Y);
                isBlocked = this.IsBlocked(currentSquare, destinationSquare, Moves.LEFT);
                if (!isBlocked)
                {
                    currentSquare.RemoveMinotaur();
                    destinationSquare.AddMinotaur();
                    theMinotaur.Update = new Position(movingMinotaur.X, movingMinotaur.Y);
                    return;
                }

            }
            // If moving left and right is blocked.
            if (isBlocked)
            {

                if (whereIsTheseus.X < whereIsMinotaur.X)
                {
                    // Will move up
                    var moveDirection = Moves.UP;
                    MoveMinotaur(whereIsMinotaur, currentSquare, moveDirection);
                    return;
                }
                else if (whereIsTheseus.X > whereIsMinotaur.X)
                { // Move down
                    var moveDirection = Moves.DOWN;
                    MoveMinotaur(whereIsMinotaur, currentSquare, moveDirection);
                    return;
                }
            }
            if (isBlocked)
            {
                return;
            }

        }

        public bool CheckIfTheseusWon()
        {
            if (theExit.X.Equals(theTheseus.X) && theExit.Y.Equals(theTheseus.Y))
            {
                this.theExit.AddTheseus();
                this.hasTheseusWon = true;

            }
            return this.hasTheseusWon;
        }

        public bool CheckIfMinotaurWon()
        {
            if (theMinotaur.X.Equals(theTheseus.X) && theMinotaur.Y.Equals(theTheseus.Y))
            {
                this.theMinotaur.AddTheseus();
                this.hasMinotaurWon = true;
            }
            return this.hasMinotaurWon;
        }

        private void MoveMinotaur(Position whereIsMinotaur, Square currentSquare, (int, int) moveDirection)
        {
            Position newtheMinotaur = theMinotaur.Move(moveDirection, whereIsMinotaur);
            var destinationSquare = this.GetSquare(newtheMinotaur.X, newtheMinotaur.Y);
            UpdateMinotaurIfNotBlocked(currentSquare, destinationSquare, moveDirection, whereIsMinotaur);
        }

        private void UpdateMinotaurIfNotBlocked(Square aSquare, Square destination, (int, int) moveDirection, Position whereIsMinotaur)
        {
            var isBlocked = this.IsBlocked(aSquare, destination, moveDirection);
            if (!isBlocked)
            {
                aSquare.RemoveMinotaur();
                Position newtheMinotaur = theMinotaur.Move(moveDirection, whereIsMinotaur);
                var destinationSquare = this.GetSquare(newtheMinotaur.X, newtheMinotaur.Y);
                theMinotaur.Update = new Position(newtheMinotaur.X, newtheMinotaur.Y);
                destinationSquare.AddMinotaur();
            }

        }

        public bool IsBlocked(Square current, Square destination, (int, int) moveDirection)
        {
            bool isCurrentBlocked = false;
            bool isDestinationBlocked = false;

            if (moveDirection.Equals(Moves.UP))
            {
                isDestinationBlocked = destination.Bottom;
                isCurrentBlocked = current.Top;
            }
            if (moveDirection.Equals(Moves.DOWN))
            {
                isDestinationBlocked = destination.Top;
                isCurrentBlocked = current.Bottom;
            }
            if (moveDirection.Equals(Moves.LEFT))
            {
                isDestinationBlocked = destination.Right;
                isCurrentBlocked = current.Left;

            }
            if (moveDirection.Equals(Moves.RIGHT))
            {
                isDestinationBlocked = destination.Left;
                isCurrentBlocked = current.Right;
            }

            if (isCurrentBlocked || isDestinationBlocked || moveDirection.Equals(Moves.PAUSE))
            {
                return true;
            }
            return false;
        }

        public Square GetSquare(int x, int y)
        {
            // This if is if the square is out of bound
            if (x < 0)
            {
                x = 0;
            }
            if (y < 0)
            {
                y = 0;
            }
            if (y.Equals(this.Width)) {
                y = this.Width-1;
            }
            if (x.Equals( this.Height))
            {
                x = this.Height-1;
            }
            return (Square)this.maze[x, y];
        }

        
        public void PlaceMazeCharacter()
        {

            for (int i = 0; i < 15; i += 5)
            {
                int row = int.Parse(data.Substring(i, 2));
                int col = int.Parse(data.Substring(i + 2, 2));
                Square aSquare;

                switch (i)
                {
                    case 0:
                        theMinotaur = new Minotaur(row, col);
                        aSquare = this.GetSquare(row, col);
                        aSquare.AddMinotaur();
                        break;
                    case 5:
                        theTheseus = new Theseus(row, col);
                        aSquare = this.GetSquare(row, col);
                        aSquare.AddTheseus();
                        break;
                    case 10:
                        theExit = new Exit(row, col);
                        aSquare = this.GetSquare(row, col);
                        aSquare.AddExit();
                        break;
                }

            }

        }

    }

}
