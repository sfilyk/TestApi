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
            var taskData = new TaskData();
            var responce = taskData.GetKeyId();
           //Assert.AreEqual(2,responce.guest_session_id);
            Assert.AreEqual("true",responce.success);
        }

        

    }
}