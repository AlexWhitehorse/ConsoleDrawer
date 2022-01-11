using ConsoleDrawer.Common;
using ConsoleDrawer.Resources;
using System;

namespace ConsoleDrawer
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw();
        }

        private static void Draw()
        {
            var sb = new SymbolsBase(1, 1);
            sb.AddSymbol();
            sb.DrawSymbol();
            return;
        }
    }
}
