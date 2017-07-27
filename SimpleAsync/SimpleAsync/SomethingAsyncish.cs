using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleAsync
{
    public sealed class SomethingAsyncish
    {
        public static async Task ThisWillFail()
        {
            const int SECONDS = 5;
            await Task.Delay(TimeSpan.FromSeconds(SECONDS));
            throw new Exception($"Failed after {SECONDS} seconds.");
        }

        public static async Task<IEnumerable<string>> ReturnSomeStuff()
        {
            const int SECONDS = 5;
            await Task.Delay(TimeSpan.FromSeconds(SECONDS));
            var result = new[] {"Stuff", "Thingy", "Potato" };
            return result;
        }
    }
}
