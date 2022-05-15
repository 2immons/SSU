using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Task1_Round.BLL;
using Task1_Round.DAL;
using Task1_Round.Entities;

namespace UnitTests
{
    [TestClass]
    public class BLLTests
    {
        public Mock<IRoundRepo> roundRepo;
        public RoundLogiclmpl roundLogiclmpl;

        public BLLTests()
        {
            this.roundRepo = new Mock<IRoundRepo>();
            Point center = new Point(5, 5);
            roundRepo.Setup(r => r.Add(It.IsAny<Round>())).Returns(() => new Round(center, 5));
            this.roundLogiclmpl = new RoundLogiclmpl(roundRepo.Object);
        }

        [TestMethod]
        public void AddCorrectRound()
        {
            Point center = new Point(5, 5);
            Assert.IsNotNull(roundLogiclmpl.Create(center, 10));
        }

        [TestMethod]
        public void AddRoundWithNegativeRadius()
        {
            Point center = new Point(5, 5);
            Assert.ThrowsException<System.Exception>(() => roundLogiclmpl.Create(center, -10));
        }
    }

    [TestClass]
    public class DALTests
    {
        public RoundInMemoryRepo roundInMemoryRepo;
        public Round round;

        public DALTests()
        {
            round = new Round(new Point(5, 5), 5);
            roundInMemoryRepo = new RoundInMemoryRepo();
        }

        [TestMethod]
        public void CreateRoundTest()
        {
            Assert.IsNotNull(roundInMemoryRepo.Add(round));
        }

        [TestMethod]
        public void UpdateRoundNegativeId()
        {
            Assert.ThrowsException<System.Exception>(() => roundInMemoryRepo.Update(-1, round));
        }

        [TestMethod]
        public void DeleteRoundNegativeId()
        {
            Assert.AreEqual(false, roundInMemoryRepo.Delete(-1));
        }
    }

}
