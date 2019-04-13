using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facade;
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

        [TestMethod]
        public void IdCodeTest()
        {
            p.setIdCode(new Patient("First", "Last", "39805225211", "kõrv valutab"));
            Assert.AreEqual("39805225211", p.IdCode);
        }


        //string firstName, string lastName, string idCode, string problem, DateTime? validFrom = null, DateTime? validTo = null)
        [TestMethod]
        public void PatientNameTest()
        {
            p.setName(new Patient("First", "Last", "39805225211", "kõrv valutab"));
            Assert.AreEqual("First Last", p.PatientName);

        }
        [TestMethod]
        public void PatientidCodeTest()
        {
            //IdCode = p.IdCode;
            p.setName(new Patient("First", "Last", "39805225211", "kõrv valutab"));
            Assert.AreEqual("First Last", p.PatientName);

        }
        [TestMethod]
        public void PatientProblemTest()
        {
            p.setProblem(new Patient("First", "Last", "39805225211", "randomproblem"));
            Assert.AreEqual("randomproblem", p.Problem);

        }
        [TestMethod]
        public void PatientProblemColorTest1() //Kui probleem on Head (ehk peavalu)
        {
            p.setProblemColor(new Patient("First", "Last", "39805225211", "Head"));
            Assert.AreEqual("Yellow", p.ProblemColor);

        }
        [TestMethod]
        public void PatientProblemColorTest2()
        {
            p.setProblemColor(new Patient("First", "Last", "39805225211", "randomproblem"));
            Assert.AreEqual("Magenta", p.ProblemColor);

        }
        //[TestMethod] //Should we do it?
        //public void PatientProblemColorTest3() //If patient = null ehk kui teda pole olemas
        //{
        //    p.setProblemColor(new Patient(null, null, null, null));
        //    Assert.AreEqual("Red", p.ProblemColor);

        //}

       


        //public void setIdCode(Patient p)
        //{
        //    IdCode = p.IdCode;
        //}

        //public void setValidFrom(Patient p)
        //{
        //    ValidFrom = p.ValidFrom;
        //}
        //public void setValidTo(Patient p)
        //{
        //    ValidTo = p.ValidTo;
    }
}
