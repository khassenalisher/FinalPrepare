using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 0; k < 10; k++)
            {
                int y = 10;
                
                for (int x = 0; x < 10; x +=1)
                {
                    Console.SetCursorPosition(x, y);
                    y++;
                    Console.Write(".");
                    Thread.Sleep(30);
                    
                }
                Console.SetCursorPosition(10, y);
                Console.Write(".");
                for (int x = 11; x < 21; x += 1)
                {
                    Console.SetCursorPosition(x, y);
                    y--; 
                    Console.Write(".");
                    Thread.Sleep(30);

                }
                Console.SetCursorPosition(21, y);
                Console.Write(".");
                for (int x = 22; x < 32; x += 1)
                {
                    Console.SetCursorPosition(x, y);
                    y++;
                    Console.Write(".");
                    Thread.Sleep(30);

                }
                Console.SetCursorPosition(32, y);
                Console.Write(".");
                for (int x = 33; x < 43; x += 1)
                {
                    Console.SetCursorPosition(x, y);
                    y--;
                    Console.Write(".");
                    Thread.Sleep(30);

                }
                Console.SetCursorPosition(43, y);
                Console.Write(".");
                for (int x = 44; x < 54; x += 1)
                {
                    Console.SetCursorPosition(x, y);
                    y++;
                    Console.Write(".");
                    Thread.Sleep(30);

                }
                Console.SetCursorPosition(54, y);
                Console.Write(".");
                for (int x = 55; x < 65; x += 1)
                {
                    Console.SetCursorPosition(x, y);
                    y--;
                    Console.Write(".");
                    Thread.Sleep(30);

                }
                Console.Clear();
                Thread.Sleep(30);
            }
        }
    }
}
