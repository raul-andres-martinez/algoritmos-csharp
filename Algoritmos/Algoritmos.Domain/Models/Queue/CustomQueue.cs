namespace Algoritmos.Domain.Models.Queue
{
    public class CustomQueue<T>
    {
        private List<T> Items = new List<T>();

        public CustomQueue(List<T> items)
        {
            Items = items;
        }

        public void Enqueue(T item)
        {
            Items.Add(item);
        }

        public void Dequeue()
        {
            Items.RemoveAt(0);
        }

        public int Count()
        {
            return Items.Count();
        }
    }
}
