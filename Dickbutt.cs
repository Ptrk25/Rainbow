using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dickbutt2
{
    class Dickbutt
    {

        static int line = 0;
        static int red = 0;
        static int blue = 240;
        static int green = 120;

        public static void drawFrame()
        {
            changeColor();
            for (int i = 0; i < 231; i++)
            {
                Draw.goToPaintPos(line * 5, 0);
                Win32.LeftHold();
                Draw.moveY(648);
                Win32.LeftRelease();
                line++;
                changeColor();
            }
            
        }

        private static void changeColor()
        {
            Win32.LeftClick(1120, 75);
            Thread.Sleep(100);
            Win32.LeftClick(755, 589);
            Thread.Sleep(50);

            // ROT
            Win32.LeftClick(1085, 599);
            Thread.Sleep(2);
            SendKeys.Send("{BS}{BS}{BS}" + red);
            red += 1;

            // GRÜN
            Thread.Sleep(2);
            Win32.LeftClick(1085, 621);
            Thread.Sleep(2);
            SendKeys.Send("{BS}{BS}{BS}" + blue);

            // BLAU
            Thread.Sleep(2);
            Win32.LeftClick(1085, 644);
            Thread.Sleep(2);
            SendKeys.Send("{BS}{BS}{BS}" + green);

            Win32.LeftClick(773, 666);
            Thread.Sleep(2);
        }

    }
}
