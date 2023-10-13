namespace Algoritmos.Domain.Models.Stack
{
    public class StackCustom<T>
    {
        private readonly List<T> Items = new List<T>();

        public StackCustom(List<T> items)
        {
            Items = items;
        }

        public void Push(T item)
        {
            Items.Add(item);
        }

        public T Pop()
        {
            if (Items.Count == 0)
            {
                throw new InvalidOperationException("A pilha está vazia.");
            }

            int lastIndex = Items.Count - 1;
            T item = Items[lastIndex];
            Items.RemoveAt(lastIndex);
            return item;
        }

        public int Count()
        {
            return Items.Count;
        }

        public T Peek()
        {
            return Items[0];
        }
    }
}
