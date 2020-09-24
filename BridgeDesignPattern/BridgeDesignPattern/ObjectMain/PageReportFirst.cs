using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.ObjectMain
{
    public class PageReportFirst : IPage
    {
        public string GetPage()
        {
            return "Print page Report First";
        }
    }
}
