using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern.ObjectMain.Decorators
{
    public class Decorator : IDecorator
    {
        IPage _page;

        public Decorator(IPage page)
        {
            _page = page;
        }

        public string GetPage()
        {
            return _page.GetPage();
        }

        public void TestMethod()
        {
            Console.WriteLine(_page.GetPage() + " decorator");
        }
    }
}
