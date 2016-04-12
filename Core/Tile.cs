using System;

namespace BudaDude.Core
{
	public class Tile
	{
		public Tile (int x, int y)
		{
		this.X = x;
		this.Y = y;
		}

		public int X;
		public int Y;

		public int Height;
		public int Width;
	}

}

