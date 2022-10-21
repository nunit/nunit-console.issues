using NUnit.Framework;

namespace Test1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void WithoutFramework()
        {
            Assert.Pass();
        }

        [Test]
        public void WithFramework()
        {
            var checkbox = new CheckBox();
            Assert.Pass();
        }
    }
}