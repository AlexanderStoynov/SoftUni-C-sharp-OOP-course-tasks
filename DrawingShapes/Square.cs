using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Square : IDrawable
    {
        public Square(int side)
        {
            Side = side;
        }

        public int Side { get; }

        public void Draw()
        {
            for (int i = 0; i < Side; i++)
            {
                for (int j = 0; j < Side; j++)
                {
                    if (i == 0 || i == Side -1 || j == 0 || j == Side -1)
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
