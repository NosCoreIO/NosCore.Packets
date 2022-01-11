//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NosCore.Packets
{
    public class Game18NArguments : IList<object>, ICollection
    {
        private readonly List<object> _list;
        private readonly int _size;

        public Game18NArguments(int size)
        {
            _size = size;
            _list = new List<object>(size);
        }

        public object this[int index]
        {
            get => _list.Count < index && index < _size ? 0 : _list[index];
            set => _list[index] = value;
        }

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public bool IsSynchronized => false;

        public object SyncRoot => new();

        public void Clear() => _list.Clear();

        public bool Contains(object item) => _list.Contains(item);

        public void CopyTo(object[] array, int arrayIndex) => _list.CopyTo(array, arrayIndex);

        public IEnumerator<object> GetEnumerator() => _list.Concat(Enumerable.Repeat<object>(0, _size - _list.Count)).GetEnumerator();

        public int IndexOf(object item) => _list.IndexOf(item);

        public void Insert(int index, object item) => _list.Insert(index, item);
        public bool Remove(object item) => _list.Remove(item);

        public void RemoveAt(int index) => _list.RemoveAt(index);

        public void Add(object item)
        {
            if (_list.Count == _size)
            {
                _list.RemoveAt(0);
            }
            _list.Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator() => _list.Concat(Enumerable.Repeat<object>(0, _size - _list.Count)).GetEnumerator();

        public void CopyTo(Array array, int index) => _list.CopyTo((object[])array, index);
    }
}