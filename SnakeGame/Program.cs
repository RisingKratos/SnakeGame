using Snake.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            MySnake worm = new MySnake();
            Food food = new Food();
            Wall fence = new Wall();

            Console.SetWindowSize(41, 41);

            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {

                        
                    case ConsoleKey.UpArrow:
                        if (worm.Move(0, -1, food.location) == 2)
                        {
                            food = new Food();
                            fence = new Wall();
                        }
                        if (worm.Move(0, -1, food.location) == 3) 
                        {
                            return;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (worm.Move(0, 1, food.location) == 2)
                        {
                            food = new Food();
                            fence = new Wall();
                        }
                        if (worm.Move(0, -1, food.location) == 3)
                        {
                            return;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (worm.Move(-1, 0, food.location) == 2)
                        {
                            food = new Food();
                            fence = new Wall();
                        }
                        if (worm.Move(0, -1, food.location) == 3)
                        {
                            return;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (worm.Move(1, 0, food.location) == 2)
                        {
                            food = new Food();
                            fence = new Wall();
                        }
                        if (worm.Move(0, -1, food.location) == 3)
                        {                           
                            return;
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;
                    
                    default: break;
                }
            }
        }
    }
}