using System.Diagnostics;
using Algoritmos.Domain.Models.LinkedList;

namespace Algoritmos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça uma lista encadeada simples, contendo métodos para:
            //Verificar se existe um valor na lista;
            //Remover um elemento da lista.

            Stopwatch stopwatch = new();
            stopwatch.Start();

            SimpleLinkedList<int> list = new(new Node<int>(10));
            list.Add(new Node<int>(20));
            list.Add(new Node<int>(30));
            list.Add(new Node<int>(40));

            Console.WriteLine("Lista original:");
            list.PrintList();

            Node<int> nodeSearch = new(30);
            var search = list.GetNode(nodeSearch);

            if (search != null)
            {
                Console.WriteLine($"Valor {nodeSearch} encontrado na lista.");
            }
            else
            {
                Console.WriteLine($"Valor {nodeSearch} não encontrado na lista.");
            }

            Node<int> nodoRemover = new(20);
            list.Remove(nodoRemover);

            Console.WriteLine("Lista após a remoção:");
            list.PrintList();

            stopwatch.Stop();

            long time = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Tempo de execução: {time} ms");
        }
    }
}
