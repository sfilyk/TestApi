using NUnit.Framework;
using TaskApi;
namespace TestAPI
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var baseTask = new BaseTask();
            var responce = baseTask.GetKeyId();
            Assert.AreEqual("true",responce.success);
        }

        

    }
}