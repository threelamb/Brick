using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk
{
    class Program
    {
        static void Main(string[] args)
        {
            IntPtr res = WinAPI.FindWindow(null, "360云盘");
            if (res != IntPtr.Zero)
            {
                WinAPI.SetForegroundWindow(res);
                WinAPI.SendMessage(res, WinAPI.BM_CLICK, 0, 0);
            }
        }
    }
}
