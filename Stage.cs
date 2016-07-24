using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dickbutt2
{
    class Stage
    {
        public static void openMSPaint()
        {
            System.Diagnostics.Process.Start("mspaint.exe");
            Thread.Sleep(500);
        }

        public static void setBrush()
        {
            Win32.LeftClick(740, 72);
            Thread.Sleep(500);
            Win32.LeftClick(740, 225);
        }

    }
}
