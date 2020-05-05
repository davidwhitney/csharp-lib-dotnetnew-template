using ToolTemplate;
using NUnit.Framework;

namespace LibraryTemplate.Test.Unit
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Test1()
        {
            var instance = new Program();

            Assert.That(instance, Is.Not.Null);
        }
    }
}
