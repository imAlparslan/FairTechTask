using System;

namespace RemotingTask.RemoteObjects
{
    [Serializable]
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

    }
}
