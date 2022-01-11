using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDrawer.Common
{
    public class SymbolsBase
    {
        // Parameters of symbols
        private int _height;
        private int _width;

        private Dictionary<string, string[,]> symbols;

        public SymbolsBase(int height, int width)
        {
            _height = height;
            _width = width;
            symbols = new Dictionary<string, string[,]>();
        }

        public void AddSymbol()
        {
            int[,] s = new int[,] { };

            symbols.Add("H", new string[,]
            {
                { " ","_"," "," "," ","_"," " },
                { "|"," ","|"," ","|"," ","|" },
                { "|"," ","|","_","|"," ","|" },
                { "|"," "," ","_"," "," ","|" },
                { "|","_","|"," ","|","_","|" },
            });

            symbols.Add("E", new string[,] 
            {
                { " ","_","_","_","_","_"," " },
                { "|"," ","_","_","_","_","|" },
                { "|"," "," ","_","_","|"," " },
                { "|"," ","|"," "," "," "," " },
                { "|","_","_","_","_","_","|" }
            });
        }

        public void DrawSymbol(string s = "H")
        {
            string[,] symb = symbols["H"];
            symb = symb.;

            for (int i = 0; i < symb.GetLength(0); i++)
            {
                for (int j = 0; j < symb.GetLength(1); j++)
                {
                    Console.Write(symb[i, j]);
                    Thread.Sleep(100);
                }
                Console.Write("\n");
            }
        }
    }
}
