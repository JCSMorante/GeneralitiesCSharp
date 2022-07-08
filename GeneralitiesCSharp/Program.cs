using GeneralidadesCSharp.AsyncTopic;
using GeneralitiesCSharp.AbstractClassTopic;
using System;
using System.Threading.Tasks;

namespace GeneralidadesCSharp
{
    class Program
    {

        public static async Task Main(string[] args)
        {
            //AsyncExample asyncExample = new();
            //await asyncExample.InitExample();

            AbstractExample ae = new();
            ae.RunExample();
        }


    }
}
