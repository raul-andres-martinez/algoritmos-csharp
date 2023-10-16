namespace Algoritmos.Domain.Models.LinkedList
{
    public class DoublyLinkedList<T>
    {
        public Node<T>? Head { get; set; }
        public Node<T>? Tail { get; set; }

        public DoublyLinkedList(Node<T>? head, Node<T>? tail)
        {
            Head = head;
            Tail = tail;
        }

        public void Add(Node<T> node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else if(Head != null && Head.Next == null)
            {
                node.Previous = Head;
                Head.Next = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }
        }

        public void PrintByHead()
        {
            var node = Head;
            while (node != null)
            {
                Console.WriteLine(node + "");
                node = node.Next;
            }
        }

        public void PrintByTail()
        {
            var node = Tail;
            while (node != null)
            {
                Console.WriteLine(node + "");
                node = node.Previous;
            }
        }

        public Node<T>? GetNodeByHead(Node<T> node)
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

        public Node<T>? GetNodeByTail(Node<T> node)
        {
            var currentNode = Tail;
            while (currentNode != null)
            {
                if (EqualityComparer<T>.Default.Equals(currentNode.Value, node.Value))
                {
                    return currentNode;
                }

                currentNode = currentNode.Previous;
            }

            return null;
        }

        public void RemoveByHead(T value)
        {
            Node<T>? nodeToRemove = GetNodeByHead(new Node<T>(value));

            if (nodeToRemove == null)
            {
                return;
            }

            if (nodeToRemove == Head)
            {
                Head = Head.Next;
                if (Head != null)
                {
                    Head.Previous = null;
                }
                else
                {
                    Tail = null;
                }
            }
            else
            {
                nodeToRemove.Previous.Next = nodeToRemove.Next;
                if (nodeToRemove.Next != null)
                {
                    nodeToRemove.Next.Previous = nodeToRemove.Previous;
                }
                else
                {
                    Tail = nodeToRemove.Previous;
                }
            }
        }

        public void RemoveByTail(T value)
        {
            Node<T>? nodeToRemove = GetNodeByTail(new Node<T>(value));

            if (nodeToRemove == null)
            {
                return;
            }

            if (nodeToRemove == Tail)
            {
                Tail = Tail.Previous;
                if (Tail != null)
                {
                    Tail.Next = null;
                }
                else
                {
                    Head = null;
                }
            }
            else
            {
                nodeToRemove.Next.Previous = nodeToRemove.Previous;
                if (nodeToRemove.Previous != null)
                {
                    nodeToRemove.Previous.Next = nodeToRemove.Next;
                }
                else
                {
                    Head = nodeToRemove.Next;
                }
            }
        }
    }
}
