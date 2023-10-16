namespace Algoritmos.Domain.Models.Queue
{
    public class NodeQueue<T>
    {
        private Node<T>? Top { get; set; } = null;

        public NodeQueue(Node<T>? top = null)
        {
            Top = top;
        }

        public void Enqueue(Node<T> node)
        {
            if (IsEmpty())
            {
                Top = node;
            }
            else if (Top.Next == null)
            {
                Top.Next = node;
            }
            else
            {
                var end = FindEnd();
                end.Next = node;
            }
        }

        public Node<T>? Dequeue()
        {
            if (!IsEmpty())
            {
                var top = Top;
                Top = Top.Next;
                return top;
            }

            return null;
        }

        public Node<T>? FindEnd()
        {
            if (!IsEmpty())
            {
                var node = Top;

                while (node.Next != null)
                {
                    node = node.Next;
                }

                return node;
            }

            return null;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }

        public int Count()
        {
            var count = 0;
            var current = Top;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("A fila está vazia.");
                return;
            }

            var current = Top;
            while (current != null)
            {
                Console.Write($"{current.Value} -> ");
                current = current.Next;
            }
            Console.WriteLine("Fim da fila");
        }
    }
}
