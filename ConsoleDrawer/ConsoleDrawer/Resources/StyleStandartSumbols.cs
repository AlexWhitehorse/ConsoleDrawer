using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDrawer.Resources
{
    public class StyleStandartSumbols : StyleBaseSymbols
    {
        public StyleStandartSumbols()
        {
            Symbols = new Dictionary<string, string>() 
            {
                { "H",
@"  _   _ 
 | | | |
 | |_| |
 |  _  |
 |_| |_|
" },
                { "E",
@"  _____ 
 | ____|
 |  _|  
 | |___ 
 |_____|
        "}

            };
        }
    }
}
