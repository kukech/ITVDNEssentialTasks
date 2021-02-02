using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        T[] array;
        int position = -1;
        public MyList()
        {
            this.array = new T[0]; 
        }
        public MyList(T[] arr)
        {
            array = arr;
        }
        public int Count { 
            get
            {
                return array.Length;
            } 
        }
        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }
        public void Add(T toadd)
        {
            //в прошлых заданиях делал, лень делать это говно
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            else
                this.Reset();
                return false;
        }
        public void Reset()
        {
            this.position = -1;
        }
        public T Current 
        {
            get
            {
                return array[position];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return array[position];
            }
        }
        public void Dispose()
        {

        }
    }
}
