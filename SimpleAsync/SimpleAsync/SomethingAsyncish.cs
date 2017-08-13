using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleAsync
{
    public sealed class SomethingAsyncish
    {
        private const int SECONDS = 5;
        public static async Task ThisWillFail()
        {
            await Task.Delay(TimeSpan.FromSeconds(SECONDS));
            throw new Exception($"Failed after {SECONDS} seconds.");
        }

        public static async Task<IEnumerable<string>> ReturnSomeStuff()
        {
            await Task.Delay(TimeSpan.FromSeconds(SECONDS));
            var result = new[] {"Stuff", "Thingy", "Potato" };
            return result;
        }
    }
}
