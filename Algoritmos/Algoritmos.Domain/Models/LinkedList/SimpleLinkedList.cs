namespace Algoritmos.Domain.Models.LinkedList
{
    public class SimpleLinkedList<T>
    {
        public Node<T>? Head { get; set; }

        public SimpleLinkedList(Node<T>? head)
        {
            Head = head;
        }

        public void Add(Node<T> node)
        {
            if (Head == null)
                Head = node;

            else
            {
                var tail = GetTail(Head);
                tail.Next = node;
            }
        }

        private Node<T> GetTail(Node<T> node)
        {
            if (node.Next == null)
                return node;

            return GetTail(node.Next);
        }

        public Node<T>? GetNode(Node<T> node)
        {
            var currentNode = Head;
            while (currentNode != null)
            {
                if (EqualityComparer<T>.Default.Equals(currentNode.Value, node.Value))
                {
                    return currentNode;
                }

                currentNode = currentNode.Next;
            }

            return null;
        }

        public void Remove(Node<T> node)
        {
            if (Head == null)
            {
                return;
            }

            if (EqualityComparer<T>.Default.Equals(Head.Value, node.Value))
            {
                Head = Head.Next;
                return;
            }

            Node<T>? currentNode = Head;
            while (currentNode?.Next != null)
            {
                if (EqualityComparer<T>.Default.Equals(currentNode.Next.Value, node.Value))
                {
                    currentNode.Next = currentNode.Next.Next;
                    return;
                }
                currentNode = currentNode.Next;
            }
        }

        public void PrintList()
        {
            Node<T>? node = Head;
            while (node != null)
            {
                Console.Write(node + " ");
                node = node.Next;
            }

            Console.WriteLine();
        }
    }
}
