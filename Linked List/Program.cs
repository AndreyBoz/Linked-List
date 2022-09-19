using System;
namespace Linked_List {
    class Program {
        static void Main(string[] args) {
            var list = new Model.LinkedList<int>();
            var list2 = new Model.LinkedList<int>();
            
            list.Add(2);
            list.Add(3);
            list.Add(1);
            list.Add(2);
            list.Add(6);
            list.Add(7);
            list.AppendHead(4);
            list2.Add(0);
            list2.Add(0);
            list2.Add(1);
            

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine();
            list.AddList(list2);
            Console.WriteLine();
            list.DeleteLast();

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}