using NUnit.Framework;

namespace LibraryTemplate.Test.Unit
{
    [TestFixture]
    public class Class1Tests
    {
        [Test]
        public void Test1()
        {
            var instance = new Class1();

            Assert.That(instance, Is.Not.Null);
        }
    }
}
