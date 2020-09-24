using BridgeDesignPattern.ObjectMain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.BridgeDesign
{
    public abstract class SystemPrintPage
    {
        public IPage _page;
        public abstract void PrintPage();
    }
}
