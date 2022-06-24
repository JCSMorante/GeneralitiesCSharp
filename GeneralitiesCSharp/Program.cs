using GeneralidadesCSharp.AsyncTopic;
using System;
using System.Threading.Tasks;

namespace GeneralidadesCSharp
{
    class Program
    {

        public static async Task Main(string[] args)
        {
            AsyncExample asyncExample = new();
            await asyncExample.InitExample();
        }


    }
}
