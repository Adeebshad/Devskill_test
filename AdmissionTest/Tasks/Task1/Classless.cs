using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Classless
    {
        public int Count { get; set; }

        public void Add(int item)
        {
            Console.WriteLine("Classless Add");
            //throw new NotImplementedException();
        }

        public int Get(int index)
        {
            //Console.WriteLine("Classless Get");
            throw new NotImplementedException();
        }

        public void Remove(int item)
        {
            Console.WriteLine("Classless Remove");
            //throw new NotImplementedException();
        }
    }
}
