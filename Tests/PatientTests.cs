using System;
using System.Collections.Generic;
using System.Text;
using HospitalRegistry.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PatientTests
    {
        [TestMethod]
        public void FirstNameTest()
        {
            Patient p = new Patient("Marko", "Jogi", "39805225211", "problem");
            Assert.AreEqual("Marko", p.FirstName);
        }

        [TestMethod]
        public void LastNameTest()
        {
            Patient p = new Patient("Marko", "Jogi", "39805225211", "problem");
            Assert.AreEqual("Jogi", p.LastName);
        }

        [TestMethod]
        public void IdCodeTest()
        {
            Patient p = new Patient("Marko", "Jogi", "39805225211", "problem");
            Assert.AreEqual("39805225211", p.IdCode);
        }

        [TestMethod]
        public void ProblemTest()
        {
            Patient p = new Patient("Marko", "Jogi", "39805225211", "problem");
            Assert.AreEqual("problem", p.Problem);
        }

        [TestMethod]
        public void ValidFromNoValidFromDateTest()
        {
            DateTime time = DateTime.Now;
            Patient p = new Patient("Marko", "Jogi", "39805225211", "problem");
            Assert.AreEqual(time, p.ValidFrom);
        }
        [TestMethod]
        public void ValidToNoValidToDateTest()
        {
            Patient p = new Patient("Marko", "Jogi", "39805225211", "problem");
            Assert.AreEqual(DateTime.MaxValue, p.ValidTo);
        }
        [TestMethod]
        public void ValidFromWithStartingDateTest()
        {
            Patient p = new Patient("Marko", "Jogi", "39805225211", "problem", Convert.ToDateTime("20.12.2012"));
            Assert.AreEqual(Convert.ToDateTime("20.12.2012"), p.ValidFrom);
        }
        [TestMethod]
        public void ValidToWithFinalDateTest()
        {
            Patient p = new Patient("Marko", "Jogi", "39805225211", "problem", null , Convert.ToDateTime("25.12.2012"));
            Assert.AreEqual(Convert.ToDateTime("25.12.2012"), p.ValidTo);
        }

    }
}
