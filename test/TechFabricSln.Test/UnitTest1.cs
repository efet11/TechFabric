using NUnit.Framework;

namespace TechFabricSln.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("UnitTest")]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        [Category("UnitTest")]
        public void IsBoughtBy_UserIsCustomer_ReturnTrue()
        {
            var bought = new Bought();

            var result = bought.IsBoughtBy(new User { customer = true });

            Assert.IsTrue(result);
        }
    }
}