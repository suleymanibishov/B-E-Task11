using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task11
{
    class CostumeCollection<T> where T : Person
    {
        private T[] _arr;
        public CostumeCollection()
        {
            _arr = new T[0];
        }
        public void Add(T item)
        {
            Array.Resize(ref _arr, _arr.Length+1);
            _arr[_arr.Length - 1] = item;
        }
        public void Src(int id)
        {
            foreach (var item in _arr)
            {
                if(item.Id == id)
                {
                    Console.WriteLine( item);
                }
            }
            Console.WriteLine("Isdifadeci Tapilmadi");
        }
        public void PrintAll()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
