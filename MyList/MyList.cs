using System;
using System.Collections;

namespace InterfaceLesson
{
    class MyList : IList
    {
        public object this[int index] { get { return this[index]; } set { } }

        public bool IsFixedSize { get; set; }

        public bool IsReadOnly { get; set; }

        public int Count { get; set; }

        public bool IsSynchronized { get; set; }

        public object SyncRoot { get; set; }

        public int Add(object value)
        {
            Count++;
            this[Count - 1] = value;
            return Count;
        }

        public void Clear()
        {
            while (Count != 0)
            {
                this[Count - 1] = 0;
                Count--;
            }
        }

        public bool Contains(object value)
        {
            return Count != 0;
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            array[index] = this[index];
        }

        public IEnumerator GetEnumerator()
        {
            return null;
        }

        public int IndexOf(object value)
        {
            int tmpCount = 0;
            while (tmpCount != Count)
            {
                if (this[tmpCount] == value)
                {
                    return tmpCount;
                }
                tmpCount++;
                if (tmpCount == Count)
                {
                    throw new Exception("Not Found index");
                }
            }
            return -1;
        }

        public void Insert(int index, object value)
        {
            Count++;
            int tmpCount = Count - 1;
            while (tmpCount != index)
            {
                this[tmpCount] = this[tmpCount - 1];
                tmpCount--;
            }
            this[index] = value;
        }

        public void Remove(object value)
        {
            int tmpCount = 0;
            try
            {
                while (tmpCount != IndexOf(value))
                {
                    tmpCount++;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Ошибка: {exception.Message}"); ;
            }
            while (tmpCount != Count - 2)
            {
                this[tmpCount] = this[tmpCount + 1];
                tmpCount++;
            }
            Count--;
        }

        public void RemoveAt(int index)
        {
            int tmpCount = 0;
            try
            {
                while (tmpCount != index)
                {
                    tmpCount++;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Ошибка: {exception.Message}"); ;
            }
            while (tmpCount != Count - 2)
            {
                this[tmpCount] = this[tmpCount + 1];
                tmpCount++;
            }
            Count--;
        }
    }
}