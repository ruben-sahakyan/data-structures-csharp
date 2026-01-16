namespace DataStructures.Collections
{
    internal class Node
    {
        internal string Value;
        internal Node? Next = null;

        internal Node(string value)
        {
            Value = value;
        }
    }
}