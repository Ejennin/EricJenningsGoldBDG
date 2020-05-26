using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoCompOut_Test;
using System.Diagnostics.CodeAnalysis;
using RepoCompOut_Repo;

namespace RepoCompOut_Test
{
    [TestClass]
    public class RepoTest
    {
        private CompOutRepo _repo = new CompOutRepo();

        [TestInitialize]
        public void SeedRepo()
        {
            CompOutContent bowling = new CompOutContent(25, 50.00, "Bowling", new DateTime(2020, 05, 07));
            _repo.AddCompOuting(bowling);
        }

        [TestMethod]
       public void AddCompOutingGetCount()
        {
            int expected = 1;
            int actual = _repo.GetCompOutContent().Count;
            Assert.AreEqual(expected, actual);
        }

        public void TotCostAllOutings()
        {
            
            
            CompOutContent bowling = new CompOutContent(25, 50.00, "Bowling", new DateTime(2020, 05, 07));
            _repo.AddCompOuting(bowling);


        }

        
    }
}
