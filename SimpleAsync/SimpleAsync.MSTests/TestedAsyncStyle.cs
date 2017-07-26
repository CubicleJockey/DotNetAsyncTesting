using System;
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

        //[TestMethod]
        //public void 
    }
}
