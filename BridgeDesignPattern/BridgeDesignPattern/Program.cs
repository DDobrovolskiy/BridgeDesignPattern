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

            IPage page = new PageReportFirst();
            SystemPrintPage systemPrint = new PrintInDOC();

            systemPrint._page = page;   //отправка текста
            systemPrint.PrintPage();    //печать

            Console.ReadKey();
        }
    }
}
