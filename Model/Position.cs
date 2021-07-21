using System;
using System.Collections.Generic;
using System.Text;

namespace GazelleLowcay_Final_Portfolio.Model
{
    public struct Position
    {
		public int x;
		public int y;

		public Position(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public int X
		{
			get { return this.x; }
			set
			{
				this.x = value;
			}
		}

		public int Y
		{
			get { return this.y; }
			set
			{
				this.y = value;
			}
		}

	}
}
