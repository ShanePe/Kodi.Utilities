using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using Kodi.Utilities.Exceptions;
using System.Reflection;
using Kodi.Utilities.Playlist;

namespace Kodi.Utilities.Collection
{
    /// <summary>
    /// Collection of rules
    /// </summary>
    /// <seealso cref="System.Collections.Generic.IList{Kodi.Utilities.Interfaces.IRule}" />
    public class RuleCollection : IList<IRule>
    {
        Dictionary<Type, IRule> _dataStore = new Dictionary<Type, IRule>();
        SmartPlayList _playlist;
        /// <summary>
        /// Gets or sets the <see cref="IRule"/> with the specified type.
        /// </summary>
        /// <value>
        /// The <see cref="IRule"/>.
        /// </value>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        /// <exception cref="InvalidRuleCollectionType"></exception>
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

        /// <summary>
        /// Gets or sets the <see cref="IRule"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="IRule"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        public int Count
        {
            get
            {
                return _dataStore.Count;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        internal RuleCollection(SmartPlayList playlist)
        {
            _playlist = playlist;
        }

        internal RuleCollection() { }

        /// <summary>
        /// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <exception cref="FieldExistsException"></exception>
        public void Add(IRule item)
        {
            if (_playlist != null)
                if (!item.IsFieldForPlaylist(_playlist.MediaType))
                    throw new FieldNotValidForTypeException(item, _playlist);

            if (_dataStore.ContainsKey(item.GetType()))
                throw new FieldExistsException(item);

            _dataStore.Add(item.GetType(), item);
        }

        /// <summary>
        /// Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        public void Clear()
        {
            _dataStore.Clear();
        }

        /// <summary>
        /// Determines whether the <see cref="T:System.Collections.Generic.ICollection`1" /> contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <returns>
        /// true if <paramref name="item" /> is found in the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false.
        /// </returns>
        public bool Contains(IRule item)
        {
            return _dataStore.ContainsKey(item.GetType());
        }

        /// <summary>
        /// Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.ICollection`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
        public void CopyTo(IRule[] array, int arrayIndex)
        {
            array = new IRule[_dataStore.Count - arrayIndex];
            for (int i = arrayIndex; i < _dataStore.Count; i++)
                array[i] = _dataStore[_dataStore.Keys.ElementAt(i)];
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<IRule> GetEnumerator()
        {
            return _dataStore.Values.GetEnumerator();
        }

        /// <summary>
        /// Determines the index of a specific item in the <see cref="T:System.Collections.Generic.IList`1" />.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.IList`1" />.</param>
        /// <returns>
        /// The index of <paramref name="item" /> if found in the list; otherwise, -1.
        /// </returns>
        public int IndexOf(IRule item)
        {
            for (int i = 0; i < _dataStore.Count; i++)
                if (_dataStore[_dataStore.Keys.ElementAt(i)] == item)
                    return i;
            return -1;
        }

        /// <summary>
        /// Inserts an item to the <see cref="T:System.Collections.Generic.IList`1" /> at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
        /// <param name="item">The object to insert into the <see cref="T:System.Collections.Generic.IList`1" />.</param>
        public void Insert(int index, IRule item)
        {
            Add(item);
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <returns>
        /// true if <paramref name="item" /> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false. This method also returns false if <paramref name="item" /> is not found in the original <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </returns>
        public bool Remove(IRule item)
        {
            return
                _dataStore.Remove(item.GetType());
        }

        /// <summary>
        /// Removes the <see cref="T:System.Collections.Generic.IList`1" /> item at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the item to remove.</param>
        public void RemoveAt(int index)
        {
            _dataStore.Remove(_dataStore.Keys.ElementAt(index));
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _dataStore.Values.GetEnumerator();
        }

        /// <summary>
        /// Adds a range of rules.
        /// </summary>
        /// <param name="items">The items.</param>
        public void AddRange(IEnumerable<IRule> items)
        {
            foreach (IRule item in items)
                Add(item);
        }
    }
}
