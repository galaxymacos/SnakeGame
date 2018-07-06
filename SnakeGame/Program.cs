using System;

namespace SnakeGame
{
    public class Snake
    {
        public Snake(int width, int height)
        {
            Canvas = new char[height,width];
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int XSpeed { get; set; }
        public int YSpeed { get; set; }
        public char[,] Canvas { get; }

        public void CreateCanvas()
        {
            for (int i = 0; i < Canvas.GetLength(0); i++)
            {
                Canvas[i, 0] = '*';
                Canvas[i, Canvas.GetLength(1)] = '*';
            }

            for (int i = 0; i < Canvas.GetLength(1); i++)
            {
                Canvas[0, i] = '*';
                Canvas[Canvas.GetLength(0), i] = '*';
            }
        }

        public void PrintMap()
        {
            for (int i = 0; i < Canvas.GetLength(0); i++)
            {
                for (int j = 0; j < Canvas.GetLength(1); j++)
                {
                    Console.Write(Canvas[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
    
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Snake snake = new Snake(100,20);
            
        }
    }
}