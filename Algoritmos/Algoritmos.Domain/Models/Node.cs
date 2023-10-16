namespace Algoritmos.Domain.Models
{
    public class Node<T>
    {
        public T? Value { get; set; }
        public Node<T>? Next { get; set; } = null;
        public Node<T>? Previous { get; set; } = null;

        public Node(T value, Node<T>? next = null, Node<T>? previous = null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }

        public override string ToString()
        {
            return Value?.ToString() ?? "null";
        }
    }
}
