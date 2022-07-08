using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralidadesCSharp.AsyncTopic
{
    /// <summary>
    /// While the oven works, the person washes the dishes.
    /// </summary>
    public class AsyncExample
    {

        public async Task InitExample()
        {
            
            var taskBake = Bake().GetAwaiter();
            taskBake.GetResult();
            var taskDishwashing = Dishwashing();

            //await taskBake;
            await taskDishwashing;

            Console.Read();
        }
        public async Task <bool> Bake()
        {
            Console.WriteLine("The oven is on");
            await Task.Delay(10000);
            Console.WriteLine("The oven is off");
            return true;

        }

        public async Task Dishwashing()
        {
            Console.WriteLine("Start the dishwashing");
            await Task.Delay(2000);
            Console.WriteLine("Finish the dishwashing");
        }
    }
}
