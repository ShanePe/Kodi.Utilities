using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Kodi.Utilities.Exceptions;
using System.Reflection;

namespace Kodi.Utilities.Collection
{
    public class RuleCollection : IList<IRule>
    {
        Dictionary<Type, IRule> _dataStore = new Dictionary<Type, IRule>();

        public IRule this[Type type]
        {
            get
            {
                return _dataStore.ContainsKey(type) ?
                  _dataStore[type] :
                  null;
            }
            set
            {
                if (!typeof(IRule).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
                    throw new InvalidRuleCollectionType(type);

                if (_dataStore.ContainsKey(type))
                    _dataStore[type] = value;
                else
                    Add(value);

            }
        }
        public IRule this[int index]
        {
            get
            {
                return _dataStore[_dataStore.Keys.ElementAt(index)];
            }

            set
            {
                Type key = _dataStore.Keys.ElementAt(index);
                if (key != null)
                    _dataStore[key] = value;
            }
        }

        public int Count
        {
            get
            {
                return _dataStore.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(IRule item)
        {
            if (_dataStore.ContainsKey(item.GetType()))
                throw new FieldExistsException(item);

            _dataStore.Add(item.GetType(), item);
        }

        public void Clear()
        {
            _dataStore.Clear();
        }

        public bool Contains(IRule item)
        {
            return _dataStore.ContainsKey(item.GetType());
        }

        public void CopyTo(IRule[] array, int arrayIndex)
        {
            array = new IRule[_dataStore.Count - arrayIndex];
            for (int i = arrayIndex; i < _dataStore.Count; i++)
                array[i] = _dataStore[_dataStore.Keys.ElementAt(i)];
        }

        public IEnumerator<IRule> GetEnumerator()
        {
            return _dataStore.Values.GetEnumerator();
        }

        public int IndexOf(IRule item)
        {
            for (int i = 0; i < _dataStore.Count; i++)
                if (_dataStore[_dataStore.Keys.ElementAt(i)] == item)
                    return i;
            return -1;
        }

        public void Insert(int index, IRule item)
        {
            Add(item);
        }

        public bool Remove(IRule item)
        {
            return
                _dataStore.Remove(item.GetType());
        }

        public void RemoveAt(int index)
        {
            _dataStore.Remove(_dataStore.Keys.ElementAt(index));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _dataStore.Values.GetEnumerator();
        }

        public void AddRange(IEnumerable<IRule> items)
        {
            foreach (IRule item in items)
                Add(item);
        }
    }
}
