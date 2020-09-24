using System;
using BridgeDesignPattern.ObjectMain;
using BridgeDesignPattern.BridgeDesign;

namespace BridgeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge design pattern!");
            PageBridge Report1 = new PageInPDF();
            Report1._page = new PageReportFirst();
            Report1.SavePrintReport();

            Console.ReadKey();
        }
    }
}
