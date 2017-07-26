using System;
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
    }
}
