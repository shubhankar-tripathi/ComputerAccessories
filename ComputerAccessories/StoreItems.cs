using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerAccessories
{
    [Serializable]
    public class StoreItems<T> : IList<T>
    {
        // This field will be used to keeep a count of
        // the items as they are added or removed
        int counter;
        // This array holds the items of the collection
        private T[] objects;

        // The default constructor is used to initialize the collection
        public StoreItems()
        {
            counter = 0;
            objects = new T[10];
        }

        // This method makes it possible to have a collection whose size can increase.
        // This method checks the size of the array.
        // If it is too small, its size gets increase.
        private void CheckToIncreaseSize()
        {
            if (counter >= objects.Length)
                Array.Resize<T>(ref objects, objects.Length + 5);
        }

        #region IList<T> Members

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
                if (objects[i].Equals(item))
                    return i;
            return -1;
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            // First check that the user provided a positive index that
            // is lower than the current total number of items
            if ((index >= 0) && (index < counter))
            {
                // If so, starting at that index, get the item ahead of
                // each position and assign it to the current item
                for (int i = index; i < counter - 1; i++)
                    objects[i] = objects[i + 1];

                // Since the last item is not useful anymore,
                // decrease the number of items
                counter--;
            }
        }

        #endregion

        #region ICollection<T> Members

        // This indexed property is used to represent an item based on its index
        public T this[int index]
        {
            // The get accessor is used to access the item at a specific index
            get
            {
                return objects[index];
            }
            // The set accessor can be used to replace the item at a specific index
            // or to add a new item to the end of the collection
            set
            {
                objects[index] = value;
            }
        }

        // This method is used to add a new item to the collection
        public void Add(T item)
        {
            // Find out if the array is getting too small for the next item(s)
            // If it is, increase its size by 5
            CheckToIncreaseSize();

            // Add the item at the end
            this.objects[this.counter] = item;
            // Increase the current number of items
            this.counter++;
        }

        public void Clear()
        {
            // Delete each item from the collection
            foreach (var item in objects)
                Remove(item);

            // Reset the number of items of the collection to 0
            counter = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
                if (objects[i].Equals(item))
                    return true;
            return false;
        }

        // This method is used to copy the items of this collection
        // to another variable passed as argument
        public void CopyTo(T[] array, int arrayIndex)
        {
            T[] values = new T[arrayIndex];

            for (int i = 0; i < counter; i++)
                values[i] = objects[i];

            array = values;
        }

        public int Count
        {
            get { return counter; }
        }

        // This property indicates whether the collection can receive new items
        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            // First try to get the index of the item to find out if it exists
            int index = IndexOf(item);

            // If the item was found ...
            if (index >= 0)
            {
                // ... delete it, using its index
                RemoveAt(index);
                // Since the item has been removed, return true
                return true;
            }

            // If the item was not removed (for any reason), return false
            return false;
        }

        #endregion

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            int number = 0;

            while (number < Count)
            {
                yield return objects[number];
                number++;
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            int number = 0;

            while (number < Count)
            {
                yield return objects[number];
                number++;
            }
        }

        #endregion

        public void Replace(T existingItem, T newItem)
        {
            if (counter > 0)
            {
                existingItem = newItem;
            }
        }
    }
}
