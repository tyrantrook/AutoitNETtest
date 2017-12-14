using System;
using AutoIt;

namespace AutoitNETtest
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoItX.Run("notepad.exe", "C:\\Windows\\System32");
            AutoItX.WinWaitActive("Untitled");
            AutoItX.Send("I'm in notepad");
            AutoItX.Sleep(3000);
            IntPtr winHandle = AutoItX.WinGetHandle("Untitled");
            AutoItX.WinKill(winHandle);
        }
    }
}
