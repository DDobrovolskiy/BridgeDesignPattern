using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.BridgeDesign
{
    public class PrintInDOC : SystemPrintPage
    {
        public override void PrintPage()
        {
            Console.WriteLine($"Save print Page in DOC file -> " + _page.GetPage());
        }
    }
}
