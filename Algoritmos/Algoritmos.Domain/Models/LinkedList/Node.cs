using System.Drawing;

namespace Algoritmos.Domain.Models.LinkedList
{
    public class Node<T>
    {
        public T? Value { get; set; }
        public Node<T>? Next { get; set; } = null;

        public Node(T value, Node<T>? next = null)
        {
            Value = value; 
            Next = next;
        }

        public override string ToString()
        {
            return Value?.ToString() ?? "null";
        }
    }
}
