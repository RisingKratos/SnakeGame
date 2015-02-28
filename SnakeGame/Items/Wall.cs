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
            for (int i = 0; i < 41; ++i)
            {
                fence.Add(new Point { X = i, Y = 0 });
                fence.Add(new Point { X = 0, Y = i});
                fence.Add(new Point { X = i, Y = 40});
                fence.Add(new Point { X = 40, Y = i });
            }              
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
