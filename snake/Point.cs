using System;
namespace Snake
{
	public class Point
	{
		public int x;
		public int y;
		public char sym;

		public Point()
		{
			Console.WriteLine("создается новая точка");
		}

		public void Draw()
		{
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
	}
}

