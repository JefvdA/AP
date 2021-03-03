using System;
using System.Collections.Generic;
using System.Text;

namespace Pong
{
    class Balletje
    {
        //Eigenschappen
        public int X { get; set; }
        public int Y { get; set; }
        public int VectorX { get; set; }
        public int VectorY { get; set; }

        //Methoden
        public void Update()
        {
            if (X + VectorX >= Console.WindowWidth || X + VectorX < 0)
            {
                VectorX = -VectorX;
            }
            X = X + VectorX;


            if (Y + VectorY >= Console.WindowHeight || Y + VectorY < 0)
            {
                VectorY = -VectorY;
            }
            Y = Y + VectorY;
        }

        public void TekenOpScherm()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("O");
        }
    }
}
