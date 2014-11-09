/*

Heap implementation

*/

namespace ACMPrep
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    // Default is Min heap
    public partial class Heap<T>
    {
        private IComparer<T> comparer;
        private List<T> items;

        public Heap():this(Comparer<T>.Default)
        {
        }

        public Heap(IComparer<T> comparer)
        {
            this.comparer = comparer;
            this.items = new List<T>();
        }

        public void Insert(T item)
        {
            this.items.Add(item);
            this.SiftUp();
        }

        public T Delete()
        {
            if (this.items.Count == 0)
                throw new InvalidOperationException("No element");
            
            T item = this.items[0];
            if (this.items.Count == 1)
                this.items.Remove(item);
            else
            {
                this.items[0] = this.items[this.items.Count - 1];
                this.items.RemoveAt(this.items.Count - 1);
                this.SiftDown();
            }
            return item;
        }

        public T Peek()
        {
            if (this.items.Count > 0)
                return this.items[0];
            else
                return default(T);
        }

        public bool IsEmpty()
        {
            return this.items.Count > 0;
        }

        #region Private
        private void SiftUp()
        {
            int k = this.items.Count - 1;
            while (k > 0)
            {
                int p = (k - 1) / 2;
                T item = this.items[k];
                T parent = this.items[p];
                if (this.comparer.Compare(item, parent) < 0)
                {
                    this.items[k] = parent;
                    this.items[p] = item;
                    k = p;
                }
                else
                    break;
            }
        }

        private void SiftDown()
        {
            int k = 0;
            int l = 2 * k + 1;
            while (l < this.items.Count)
            {
                int min = l, r = l + 1;
                if (r < this.items.Count) // there is a right child
                {
                    if (this.comparer.Compare(this.items[r], this.items[l]) < 0)
                        min++;
                }
                if (this.comparer.Compare(this.items[k], this.items[min]) > 0)
                {
                    //Switch
                    T temp = this.items[k];
                    this.items[k] = this.items[min];
                    this.items[min] = temp;
                    k = min;
                    l = 2 * k + 1;
                }
                else
                    break;
            }
        }
        #endregion
    }
}