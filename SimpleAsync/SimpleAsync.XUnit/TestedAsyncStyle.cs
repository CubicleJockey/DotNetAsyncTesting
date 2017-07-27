using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SimpleAsync.XUnit
{
    public class TestedAsyncStyle
    {
        [Fact]
        public async Task ThisWillFailTests()
        {
            var exception = await Assert.ThrowsAsync<Exception>(async () => { await SomethingAsyncish.ThisWillFail(); });

            Assert.IsType<Exception>(exception);
            Assert.Equal("Failed after 5 seconds.", exception.Message);
        }

        [Fact]
        public async Task SomeStuffWasReturned()
        {
            var EXPECTED = new[] { "Stuff", "Thingy", "Potato" };
            var result = await SomethingAsyncish.ReturnSomeStuff();
            
            var check = result.ToArray();

            Assert.Equal(3, check.Length);
            for (var i = 0; i < EXPECTED.Length; i++)
            {
                Assert.Equal(EXPECTED[i], check[i]);
            }
        }
    }
}
