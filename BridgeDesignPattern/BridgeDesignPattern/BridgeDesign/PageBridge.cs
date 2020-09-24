using BridgeDesignPattern.ObjectMain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.BridgeDesign
{
    public abstract class PageBridge
    {
        public IPage _page;
        public abstract void SavePrintReport();
    }
}
