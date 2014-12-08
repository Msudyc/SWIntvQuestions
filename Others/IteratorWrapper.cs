/*
Give you an iterator and a match function, design a 
new iterator which only returns elements that matches
by match function.
Ex. given an iterator of an array and match returns odd number.
*/

namespace OTHR
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public delegate bool Match(int num);

    public interface Iterator<T>
    {
        bool HasNext();
        T Next();
    }

    public class MyIterator : Iterator<int>
    {
        private Iterator<int> iterator;
        private Match match;

        private bool hasNext;
        private int next;

        public MyIterator(Iterator<int> iterator, Match match)
        {
            this.iterator = iterator;
            this.match = match;
            this.PrepareNext();
        }

        public bool HasNext()
        {
            return this.hasNext;
        }

        public int Next()
        {
            if (this.hasNext)
            {
                int v = this.next;
                this.PrepareNext();
                return v;
            }

            throw new IndexOutOfRangeException();
        }

        private void PrepareNext()
        {
            while (this.iterator.HasNext())
            {
                int value = this.iterator.Next();
                if (this.match(value))
                {
                    this.hasNext = true;
                    this.next = value;
                    return;
                }
            }

            this.hasNext = false;
        }
    }

    public class ArrayIterator : Iterator<int>
    {
        private int position = 0;
        private int[] array;

        public ArrayIterator(int[] array)
        {
            this.array = array;
        }

        public bool HasNext()
        {
            return this.position < this.array.Length;
        }

        public int Next()
        {
            if (!this.HasNext())
                throw new IndexOutOfRangeException();

            return this.array[this.position++];
        }

        public bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}