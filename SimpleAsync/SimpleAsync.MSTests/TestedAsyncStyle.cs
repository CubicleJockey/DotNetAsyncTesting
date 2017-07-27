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
        [ExpectedException(typeof(Exception))]
        public async Task ThisWillFailTests()
        {
            await SomethingAsyncish.ThisWillFail();
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
