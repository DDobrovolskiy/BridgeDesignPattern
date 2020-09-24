using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.BridgeDesign
{
    public class PrintInPDF : SystemPrintPage
    {
         public override void PrintPage()
        {
            Console.WriteLine($"Save print in PDF file -> " + _page.GetPage());
        }
    }
}
