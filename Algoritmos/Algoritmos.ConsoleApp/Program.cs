using System.Diagnostics;
using Algoritmos.Domain.Models.LinkedList;
using Algoritmos.Domain.Models.Stack;

namespace Algoritmos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ExercicioLinkedListSimples
            ////Faça uma lista encadeada simples, contendo métodos para:
            ////Verificar se existe um valor na lista;
            ////Remover um elemento da lista.

            //Stopwatch stopwatch = new();
            //stopwatch.Start();

            //SimpleLinkedList<int> list = new(new Node<int>(10));
            //list.Add(new Node<int>(20));
            //list.Add(new Node<int>(30));
            //list.Add(new Node<int>(40));

            //Console.WriteLine("Lista original:");
            //list.PrintList();

            //Node<int> nodeSearch = new(30);
            //var search = list.GetNode(nodeSearch);

            //if (search != null)
            //{
            //    Console.WriteLine($"Valor {nodeSearch} encontrado na lista.");
            //}
            //else
            //{
            //    Console.WriteLine($"Valor {nodeSearch} não encontrado na lista.");
            //}

            //Node<int> nodoRemover = new(20);
            //list.Remove(nodoRemover);

            //Console.WriteLine("Lista após a remoção:");
            //list.PrintList();

            //stopwatch.Stop();

            //long time = stopwatch.ElapsedMilliseconds;

            //Console.WriteLine($"Tempo de execução: {time} ms");
            #endregion

            #region ExercicioDoublyLinkedList
            ////Faça uma lista encadeada dupla, contendo métodos para:
            ////Verificar se existe um valor na lista;
            ////Remover um elemento da lista.

            //Stopwatch stopwatch = new();
            //stopwatch.Start();

            //DoublyLinkedList<int> list = new DoublyLinkedList<int>(null, null);

            //list.Add(new Node<int>(10));
            //list.Add(new Node<int>(20));
            //list.Add(new Node<int>(30));
            //list.Add(new Node<int>(40));

            //Console.WriteLine("Lista original (cabeça para cauda):");
            //list.PrintByHead();

            //Console.WriteLine("Lista original (cauda para cabeça):");
            //list.PrintByTail();

            //Node<int>? nodeToFind = list.GetNodeByHead(new Node<int>(30));

            //if (nodeToFind != null)
            //{
            //    Console.WriteLine($"Valor {nodeToFind.Value} encontrado na lista pela cabeça.");
            //}
            //else
            //{
            //    Console.WriteLine("Valor não encontrado na lista pela cabeça.");
            //}

            //nodeToFind = list.GetNodeByTail(new Node<int>(20));

            //if (nodeToFind != null)
            //{
            //    Console.WriteLine($"Valor {nodeToFind.Value} encontrado na lista pela cauda.");
            //}
            //else
            //{
            //    Console.WriteLine("Valor não encontrado na lista pela cauda.");
            //}

            //list.RemoveByHead(20);

            //Console.WriteLine("Lista após a remoção pela cabeça:");
            //list.PrintByHead();

            //list.RemoveByTail(40);

            //Console.WriteLine("Lista após a remoção pela cauda:");
            //list.PrintByTail();

            //stopwatch.Stop();

            //long time = stopwatch.ElapsedMilliseconds;

            //Console.WriteLine($"Tempo de execução: {time} ms");
            #endregion

            #region Stack
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //StackCustom<int> stack = new StackCustom<int>(new List<int>());

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //int count = stack.Count();
            //Console.WriteLine($"Número de elementos na pilha: {count}");

            //int topElement = stack.Peek();
            //Console.WriteLine($"Elemento no topo da pilha: {topElement}");

            //int poppedItem = stack.Pop();
            //Console.WriteLine($"Elemento removido: {poppedItem}");

            //stopwatch.Stop();
            //long time = stopwatch.ElapsedMilliseconds;
            //Console.WriteLine($"Tempo de execução: {time} ms");
            #endregion

            #region NodeStack
            ////Faca uma Stack de nós, contendo os métodos Count, Peek, Push e Pop

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //NodeStack<int> nodeStack = new NodeStack<int>(null);

            //nodeStack.Push(new Node<int>(10));
            //nodeStack.Push(new Node<int>(20));
            //nodeStack.Push(new Node<int>(30));

            //int count = nodeStack.Count();
            //Console.WriteLine($"Número de elementos na pilha: {count}");

            //Node<int> topNode = nodeStack.Peek();
            //Console.WriteLine($"Elemento no topo da pilha: {topNode.Value}");

            //Node<int> poppedNode = nodeStack.Pop();
            //Console.WriteLine($"Elemento removido: {poppedNode.Value}");

            //stopwatch.Stop();

            //long time = stopwatch.ElapsedMilliseconds;

            //Console.WriteLine($"Tempo de execução: {time} ms");
            #endregion
        }
    }
}
