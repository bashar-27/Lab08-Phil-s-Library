using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    internal class Backpack<T> : IBag<T>
    {
        private List<T> data;
        public Backpack() {

         data = new List<T>();
        }
        public void Pack(T item)
        {
            if(item != null)
            data.Add(item);
        }

        public T Unpack(int index)
        {
          
                var item = data[index];
                data.RemoveAt(index); 
                return item;
            
            
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach(var item in data)
            {
                yield return item;
            }   
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in data)
            {
                yield return item;
            }
        }
    }
}
