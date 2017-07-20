using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WidgetDemo.DAL.Persistence;

namespace WidgetDemo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            new EntityFrameWorkTest().Insert();
        }
    }
}
