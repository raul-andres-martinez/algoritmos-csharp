namespace Algoritmos.Domain.Models.Stack
{
    public class NodeStack<T>
    {
        private Node<T>? Top  = null;

        public NodeStack(Node<T>? top = null)
        {
            Top = top;
        }

        public void Push(Node<T> node)
        {
            if(Top == null)
            {
                Top = node;
            }
            else
            {
                node.Next = Top;
                Top = node;
            }
        }

        public Node<T> Pop() 
        {
            if (Top == null)
            {
                throw new InvalidOperationException("A pilha está vazia.");
            }

            var node = Top;

            if (Top.Next != null)
            {
                Top = Top.Next;
                return node;
            }

            return node;
        }

        public Node<T> Peek()
        {
            if (Top == null)
            {
                throw new InvalidOperationException("A pilha está vazia.");
            }

            return Top;
        }

        public int Count()
        {
            int count = 0;
            Node<T>? current = Top;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }
    }
}
