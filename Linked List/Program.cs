using System;
namespace Linked_List {
    class Program {
        static void Main(string[] args) {
            var list = new Model.LinkedList<int>();
            Console.WriteLine("New list - ");
            list.Add(3);
            list.Add(1);
            list.Add(2);
            Console.WriteLine("Add elements in tail 3,1,2.\nList - ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            list.AppendHead(3);
            Console.WriteLine("\nAdd element in head - 3.\nList - ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            list.DeleteLast();
            Console.WriteLine("\nDelete element in tail.\nList - ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            list.DeleteFirst();
            Console.WriteLine("\nDelete element in head.\nList - ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine($"\nElement num.1 - {list[1]}");
            list.Delete(1);
            Console.WriteLine("Delete element num.1.\nList - ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine($"\nList size - {list.Count}");
            list.Clear();
            Console.WriteLine("Delete all elements.\nList - ");
            list.Add(3);
            list.Add(1);
            list.Add(2);
            Console.WriteLine("Add elements in tail 3,1,2.\nList - ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            list.ChangeElement(1, 2);
            Console.WriteLine("\nChange elemnt num.1 - 2.\nList - ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine($"\nChecking for emptiness list - {list.IsEmpty()}");
            var list2 = new Model.LinkedList<int>();
            
            list2.Add(3);
            list2.Add(1);
            list2.Add(2);
            Console.WriteLine("New list2 - ");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write(list2[i] + " ");
            }

            list.AddList(list2);
            Console.WriteLine("\nInsertin list2 in tail of list.\nList - ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine("\nGood Luck!");
            Console.ReadLine();
        }
    }
}