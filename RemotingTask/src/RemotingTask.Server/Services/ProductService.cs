using RemotingTask.RemoteObjects;
using System;

namespace RemotingTask.Server.Services
{
    public class ProductService : MarshalByRefObject, IProductService
    {
        public string Test(string msg)
        {
            Console.WriteLine($"Test method called");
            return $"Test method called with message: {msg}";
        }
    }
}
