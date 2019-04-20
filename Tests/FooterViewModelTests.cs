using System;
using System.Collections.Generic;
using System.Text;
using Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class FooterViewModelTests
    {
        private FooterViewModel o;

        [TestInitialize]
        public void TestInitialize()
        {
            o = new FooterViewModel(null);
        }

        [TestMethod]
        public void CompanyNameTest()
        {
            o.setCompanyName("Tallinn Hospital");
            Assert.AreEqual("Tallinn Hospital", o.CompanyName);
        }

        [TestMethod]
        public void YearTest()
        {
            Assert.AreEqual(DateTime.Now.Year.ToString(), o.Year);
        }
    }

    
}
