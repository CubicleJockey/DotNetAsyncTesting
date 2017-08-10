using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleAsync.MSTests
{
    [TestClass]
    public class TestedAsyncStyle
    {
        [TestMethod]
        public async Task ThisWillFailTests()
        {
            var exception = await Assert.ThrowsExceptionAsync<Exception>(async () => { await SomethingAsyncish.ThisWillFail(); });

            Assert.IsInstanceOfType(exception, typeof(Exception));
            Assert.AreEqual("Failed after 5 seconds.", exception.Message);
        }

        [TestMethod]
        public async Task SomeStuffWasReturned()
        {
            var EXPECTED = new []{ "Stuff", "Thingy", "Potato" };
            var result = await SomethingAsyncish.ReturnSomeStuff();

            var check = result.ToArray();

            Assert.AreEqual(3, check.Length);
            for (var i = 0; i < EXPECTED.Length; i++)
            {
                Assert.AreEqual(EXPECTED[i], check[i]);
            }
        }
    }
}
