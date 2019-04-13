using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facade;
using Core;
using Infra;
using HospitalRegistry;
using HospitalRegistry.Core;

namespace Tests
{
    [TestClass]
    public class PatientViewModelTests
    {
        private PatientViewModel p;

        [TestInitialize]
        public void TestInitialize()
        {
            p = new PatientViewModel(null);
        }

        //[TestMethod]
        //public void



        //string firstName, string lastName, string idCode, string problem, DateTime? validFrom = null, DateTime? validTo = null)
        [TestMethod]
        public void PatientNameTest()
        {
            p.setName(new Patient("First", "Last", "39805225211", "kõrv valutab"));
            Assert.AreEqual("First Last", p.PatientName);

        }
        public void PatientidCode()
        {
            p.setName(new Patient("First", "Last", "39805225211", "kõrv valutab"));
            Assert.AreEqual("First Last", p.PatientName);

        }
        public void PatientProblem()
        {
            p.setName(new Patient("First", "Last", "39805225211", "kõrv valutab"));
            Assert.AreEqual("First Last", p.PatientName);

        }
    }
}