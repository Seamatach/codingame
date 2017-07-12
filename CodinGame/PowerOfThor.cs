using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CodinGame
{
    /**
    * Auto-generated code below aims at helping you parse
    * the standard input according to the problem statement.
    * ---
    * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
    **/
    class PowerOfThor
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int lightX = int.Parse(inputs[0]); // the X position of the light of power
            int lightY = int.Parse(inputs[1]); // the Y position of the light of power
            int initialTX = int.Parse(inputs[2]); // Thor's starting X position
            int initialTY = int.Parse(inputs[3]); // Thor's starting Y position

            int xThor = initialTX;
            int yThor = initialTY;
            // game loop
            while (true)
            {
                int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");
                
                // Debug message to monitor mechanics.
                Console.Error.WriteLine(xThor + " Thor's X Position");
                Console.Error.WriteLine(yThor + " Thor's Y Position");
                
                // Cardinal directions
                // Go West
                if (lightX < xThor && lightY == yThor) 
                {
                    Console.WriteLine("W");
                    xThor--;
                }
                            
                // Go East
                else if (lightX > xThor && lightY == yThor)
                {
                    Console.WriteLine("E");
                    xThor++;
                }
                            
                // Go North
                else if (lightX == xThor && lightY < yThor) 
                {
                    Console.WriteLine("N");
                    yThor--;
                }
                
                // Go South
                else if (lightX == xThor && lightY > yThor) 
                {
                    Console.WriteLine("S");
                    yThor++;
                }
                
                // Ordinal directions
                // Go NorthWest
                else if (lightX < xThor && lightY < yThor) 
                {
                    Console.WriteLine("NW");
                    xThor--;
                    yThor--;
                }
                            
                // Go NorthEast
                else if (lightX > xThor && lightY < yThor)
                {
                    Console.WriteLine("NE");
                    xThor++;
                    yThor--;
                }
                            
                // Go SouthEast
                else if (lightX > xThor && lightY > yThor) 
                {
                    Console.WriteLine("SE");
                    xThor++;
                    yThor++;
                }
                
                // Go SouthWest
                else if (lightX < xThor && lightY > yThor)
                {
                    Console.WriteLine("SW");
                    xThor--;
                    yThor++;
                }
            }
        }
    }
}
