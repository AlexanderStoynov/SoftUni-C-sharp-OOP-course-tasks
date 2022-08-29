using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : IDrawable
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; private set; }

        public void Draw()
        {
            for (int i = 0; i < this.Radius * 2 + 1; i++)
            {
                for (int j = 0; j < this.Radius * 2 + 1; j++)
                {
                    var distance = Math.Sqrt((this.Radius - i) * (this.Radius - i) + (this.Radius - j) * (this.Radius - j));

                    if (Math.Ceiling(distance) == this.Radius)
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
