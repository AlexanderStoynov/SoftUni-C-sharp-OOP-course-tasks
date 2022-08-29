using System;
using System.Collections.Generic;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<IDrawable> shapes = new List<IDrawable>();

            shapes.Add(new Circle(30));
            shapes.Add(new Rectangle(40, 20));
            shapes.Add(new Square(40));

            shapes[0].Draw();
            shapes[1].Draw();
            shapes[2].Draw();
        }
    }
}
