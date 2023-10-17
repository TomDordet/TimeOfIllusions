using System;
using System.Collections.Generic;

namespace TimeOfIllusions
{
    public class LimitedList<T>
    {
        private List<T> _items = new List<T>();
        private int maxCapacity;

        public LimitedList(List<T> items, int maxCapacity)
        {
            this._items = new List<T>(items);
            this.maxCapacity = maxCapacity;
        }

        public List<T> AddItem(T item)
        {
            if (_items.Count < maxCapacity)
            {
                _items.Add(item);
            }
            return _items;
        }
    }
}