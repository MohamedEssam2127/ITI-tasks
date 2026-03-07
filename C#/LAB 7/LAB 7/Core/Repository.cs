using System;
using System.Collections.Generic;

namespace LAB_7.Core
{
    public class Repository<T> where T : ICloneable, IComparable<T>
    {
        private List<T> _items;

        public Repository()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            _items.Add((T)item.Clone());
        }

        public bool Remove(T item)
        {
            return _items.Remove(item);
        }

        public void Sort()
        {
            _items.Sort();
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }
    }
}