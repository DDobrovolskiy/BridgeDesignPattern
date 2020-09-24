using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.BridgeDesign
{
    public class PageInPDF : PageBridge
    {
         public override void SavePrintReport()
        {
            _page.Print();
            Console.WriteLine("Save print in PDF file");
        }
    }
}
