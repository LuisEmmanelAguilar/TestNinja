using System;
using System.Collections.Generic;

namespace TestNinja.Fundamentals
{
    public class Stack<T>
    {
        private readonly List<T> _list = new List<T>();

        // returns the count on the stack
        public int Count => _list.Count;

        // adds an object on top of the stack
        public void Push(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException();

            _list.Add(obj);
        }

        // removes the object on top of the stack and also returns it
        public T Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException();

            var result = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);

            return result;
        }

        // returns the object at top of the stack
        public T Peek()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException();

            return _list[_list.Count - 1];
        }
    }
}