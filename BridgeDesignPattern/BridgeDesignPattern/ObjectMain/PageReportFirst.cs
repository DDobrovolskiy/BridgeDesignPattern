using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.ObjectMain
{
    public class PageReportFirst : IPage
    {
        public void Print()
        {
            Console.WriteLine("Print page Report First");
        }
    }
}
