using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleAsync.NUnit
{
    public class TestedAsyncStyle
    {
        [Test]
        public async Task ThisWillFailTests()
        {
            var exception  = Assert.ThrowsAsync<Exception>(async () => await SomethingAsyncish.ThisWillFail());

            Assert.IsInstanceOf<Exception>(exception);
            Assert.AreEqual("Failed after 5 seconds.", exception.Message);
        }

        [Test]
        public async Task SomeStuffWasReturned()
        {
            var EXPECTED = new[] { "Stuff", "Thingy", "Potato" };
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
