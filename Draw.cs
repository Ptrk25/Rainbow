using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dickbutt2
{
    class Draw
    {

        public static void goToStart()
        {
            Win32.SetCursorPos(5, 144);
        }

        public static void goToPaintPos(int x, int y)
        {
            x += 5;
            y += 144;

            Win32.SetCursorPos(x, y);
        }

        public static void line(int x, int y, int x2, int y2)
        {
            goToPaintPos(x, y);
            Win32.LeftHold();
            Win32.SetCursorPos(x2+5, y2+144);
            Win32.LeftRelease();
        }

        public static void moveX(int x)
        {
            x += 5;

            Win32.POINT p;
            Win32.GetCursorPos(out p);

            //x += p.X;

            while (p.X > x+1)
            {
                Win32.GetCursorPos(out p);
                Win32.SetCursorPos(p.X - 1, p.Y);
                Thread.Sleep(2);
            }

            while (p.X < x -1)
            {
                Win32.GetCursorPos(out p);
                Win32.SetCursorPos(p.X + 1, p.Y);
                Thread.Sleep(2);
            }

        }

        public static void moveY(int y)
        {
            y += 144;

            Win32.POINT p;
            Win32.GetCursorPos(out p);

            //y += p.Y;

            while (p.Y > y + 1)
            {
                Win32.GetCursorPos(out p);
                Win32.SetCursorPos(p.X, p.Y - 20);
                Thread.Sleep(1);
            }

            while (p.Y < y - 1)
            {
                Win32.GetCursorPos(out p);
                Win32.SetCursorPos(p.X, p.Y + 20);
                Thread.Sleep(2);
            }

        }


    }
}
