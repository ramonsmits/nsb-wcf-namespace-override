using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientWsdl.CancelOrderSvc;

namespace ClientWsdl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ESC to exit, any other key to cancel an order.");
            int orderId = 0;
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                var start = Stopwatch.StartNew();
                Console.WriteLine("Calling proxy to cancel order");
                var client = new WcfServiceOf_CancelOrder_ErrorCodesClient();
                var request = new CancelOrder { OrderId = ++orderId };
                var before = start.Elapsed;
                var response = client.Process(request);
                var after = start.Elapsed;
                client.Close();
                start.Stop();
                Console.WriteLine(response);
                Console.WriteLine("Stats out {0:N0}ms in {1:N0}ms", start.Elapsed.TotalMilliseconds, (after-before).TotalMilliseconds);
            }
        }
    }
}
