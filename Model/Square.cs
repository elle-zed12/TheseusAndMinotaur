using System;
using System.Collections.Generic;
using System.Text;

namespace GazelleLowcay_Final_Portfolio.Model
{
    public class Square : MazeItem
    {
        protected bool hasTop;
        protected bool hasRight;
        protected bool hasBottom;
        protected bool hasLeft;
        protected bool hasMinotaur = false;
        protected bool hasExit = false;

        public Square(int x, int y, bool newTop, bool newRight,
            bool newBottom, bool newLeft) : base(x, y)
        {
            hasTop = newTop;
            hasRight = newRight;
            hasBottom = newBottom;
            hasLeft = newLeft;
        }


        public bool Top => this.hasTop;

        public bool Right => this.hasRight;

        public bool Bottom => this.hasBottom;

        public bool Left => this.hasLeft;

        public bool Minotaur => this.hasMinotaur;

        public bool Theseus => this.hasTheseus;

        public bool Exit => this.hasExit;

        public void AddMinotaur()
        {
            // Checks condition if the square where minotaur wants to enter is empty 
            hasMinotaur = true;
        }
        public void RemoveMinotaur()
        {
            hasMinotaur = false;
        }


        public void AddExit()
        {
            hasExit = true;
        }

    }

}
