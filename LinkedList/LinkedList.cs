namespace DataStructures.Collections
{
    public class LinkedList
    {
        private Node? _head = null;
        private Node? _tail = null;
        public int Count { get; private set; }

        public string[] ToArray()
        {
            var result = new string[Count];

            var current = _head;
            int index = 0;

            while (current != null)
            {
                result[index++] = current.Value;
                current = current.Next;
            }

            return result;
        }

        /// <summary>
        /// Adds a new element to the end of the linked list.
        /// </summary>
        /// <remarks>
        /// Time complexity: O(1)  
        /// Space complexity: O(1)
        /// </remarks>
        public void AddLast(string value)
        {
            if(_head == null) 
            {
                _head = new Node(value);
                _tail = _head;
                Count++;
                return;
            }
            Node current = _tail!;
            _tail = new Node(value);
            current.Next = _tail;
            Count++;
        }
        /// <summary>
        /// Removes the last element of the linked list.
        /// </summary>
        /// <remarks>
        /// Time complexity: O(n)  
        /// Space complexity: O(1)
        /// </remarks>
        public void RemoveLast()
        {
            if(_head == null)
            {
                return;
            } else if(_head == _tail)
            {
                _head = null;
                _tail = _head;
                Count--;
                return;
            }
            Node current = _head;
            while(current != null)
            {
                if(current.Next == _tail)
                {
                    current.Next = null;
                    _tail = current;
                    Count--;
                    return;
                }
                current = current.Next;
            }
        }

        /// <summary>
        /// Adds a new element to the beginning of the linked list.
        /// </summary>
        /// <remarks>
        /// Time complexity: O(1)  
        /// Space complexity: O(1)
        /// </remarks>
        public void AddFirst(string value)
        {
            if(_head == null)
            {
                _head = new Node(value);
                _tail = _head;
                Count++;
                return;
            }
            Node tempLink = _head;
            _head = new Node(value);
            _head.Next = tempLink;
            Count++;
        }

        /// <summary>
        /// Removes the first element of the linked list.
        /// </summary>
        /// <remarks>
        /// Time complexity: O(1)  
        /// Space complexity: O(1)
        /// </remarks>
        public void RemoveFirst()
        {
            if(_head == null)
            {
                return;
            } else if(_head == _tail)
            {
                _head = null;
                _tail = null;
                Count--;
                return;
            }
            _head = _head.Next;
            Count--;
        }
        
        /// <summary>
        /// Finds the first element that matches the specified value.
        /// </summary>
        /// <remarks>
        /// Time complexity: O(n)  
        /// Space complexity: O(1)
        /// </remarks>
        public string? Find(string value)
        {
            if(_head == null)
            {
                return null;
            }
            Node current = _head;
            while(current != null)
            {
                if(current.Value == value)
                {
                    return current.Value;
                }
                current = current.Next;
            }
            return null;
        }
        /// <summary>
        /// Finds the last element that matches the specified value.
        /// </summary>
        /// <remarks>
        /// Time complexity: O(n)  
        /// Space complexity: O(1)
        /// </remarks>
        public string? FindLast(string value)
        {
            string? result = null;
            if(_head == null)
            {
                return null;
            }
            Node current = _head;
            while(current != null)
            {
                if(current.Value == value)
                {
                    result = current.Value;
                }
                current = current.Next;
            }
            return result;
        }
    }
}