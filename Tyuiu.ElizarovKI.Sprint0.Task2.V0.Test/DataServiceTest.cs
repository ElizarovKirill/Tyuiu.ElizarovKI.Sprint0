using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ElizarovKI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Kirill";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hello..., Kirill", res);
        }
    }
}
