using System;
namespace Linked_List {
    class Program {
        static void Main(string[] args) {
            var list = new Model.LinkedList<int>();
            
            list.Add(2);
            list.Add(3);
            list.Add(1);

            foreach (var item in list) {
                Console.Write(item + " ");    
            }
            list.Delete(1);
            Console.WriteLine(list.Count);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}