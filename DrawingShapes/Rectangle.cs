using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;

        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public void Draw()
        {
            for (int i = 0; i < Width; i++)
            {

                for (int j = 0; j < Height; j++)
                {
                    if (i == 0 || i == Width-1 || j == Height - 1 || j == 0)
                    {
                        Console.Write("**");
                    }

                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
