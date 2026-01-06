namespace DataStructures.Collections
{
    class Node
    {
        public string Value;
        public Node? Next = null;

        public Node(string value)
        {
            Value = value;
        }
    }
}