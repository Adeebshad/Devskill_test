using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ItemBox<T> : IStorage<T> where T : class, new()
    {
        // Write your code here
        public int Count { get; set; }

        public void Add(T item)
        {
            Console.WriteLine("Add");
            //throw new NotImplementedException();
        }

        public T Get(int index)
        {
            //Console.WriteLine("Get");
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            Console.WriteLine("Remove");
            //throw new NotImplementedException();
        }

    }
}
