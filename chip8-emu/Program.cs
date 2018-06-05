using System;

namespace chip8_emu
{
    class Program
    {
        static void Main(string[] args)
        {
            GPU.GraphicsWindow gw = new GPU.GraphicsWindow(1280, 720);
            gw.Run(60);
            Console.WriteLine("Hello World!");
        }
    }
}
