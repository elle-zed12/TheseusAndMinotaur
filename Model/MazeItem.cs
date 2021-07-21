using System;
using System.Collections.Generic;
using System.Text;

namespace GazelleLowcay_Final_Portfolio.Model
{
    public abstract class MazeItem
    {
        protected Position coordinates;
        protected bool hasTheseus = false;

        public MazeItem(int x, int y)
        {
            this.coordinates = new Position(x, y);
        }
        public Position CurrentPosition()
        {
            return this.coordinates;
        }

        public Position Update
        {
            get { return this.coordinates; }
            set
            {
                coordinates = value;
            }
        }

        public int X
        {
            get { return this.coordinates.X; }
            set
            {
                this.coordinates.X = value;
            }
        }

        public int Y
        {
            get { return this.coordinates.Y; }
            set
            {
                this.coordinates.Y = value;
            }
        }

        public void AddTheseus() 
        {
            this.hasTheseus = true;
        }

        public void RemoveTheseus()
        {
            hasTheseus = false;
        }

        public Position Move((int, int) move, Position currentPosition)
        {            
            return new Position(move.Item1 + currentPosition.X, move.Item2 + currentPosition.Y);

        }
    }
}
