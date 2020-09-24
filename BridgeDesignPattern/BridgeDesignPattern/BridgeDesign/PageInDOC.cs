using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.BridgeDesign
{
    public class PageInDOC : PageBridge
    {
        public override void SavePrintReport()
        {
            _page.Print();
            Console.WriteLine("Save print Page in DOC file");
        }
    }
}
