using Snake.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Items
{
    public class Wall
    {
        char sign = '$';
        List<Point> fence = null;
        public Wall()
        {
            
            fence = new List<Point>();
            fence.Add(new Point{ X = 10,Y = 5 });
           
            Show();
        }
        public void Show()
        {
            foreach (Point w in fence)
            {
                Console.SetCursorPosition(w.X, w.Y);
                Console.Write(sign);
            }
        }                       
    }
}
