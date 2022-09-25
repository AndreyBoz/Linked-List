using System;
using System.Collections;
using System.Collections.Generic;


namespace Linked_List.Model
{
    public class LinkedList<T>
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }
        public LinkedList() {
            DeleteAll();
        }
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }
        public T this[int index] {
            get {
                if (index < 0) throw new ArgumentOutOfRangeException();
                var current = Head;
                for (int i = 0; i < index; i++)
                {
                    if (current.Next == null)
                        throw new ArgumentOutOfRangeException();
                    current = current.Next;
                }
                return current.Data;
            }
        }
        public void Add(T data) {
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else {
                SetHeadAndTail(data);
            } 
        }
        public void AppendHead(T data)
        {

            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;

            Count++;
        }
        public void InsertAfter(int index, T data)
        {
            if (Head != null)
            {

                var current = Head;

                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                var item = new Item<T>(data);
                item.Next = current.Next;
                current.Next = item;
                Count++;
            }
        }
        public void Delete(int index)
        {
            if (Head != null)
            {
                if (index == 0)
                {
                    DeleteFirst();
                    return;
                }
                var current = Head;
                for(int i = 0; i < index; i++)
                {
                    if (current.Next.Equals(Tail))
                    {
                        current.Next = null;
                        Tail = current;
                        Count--;
                        return;
                    }
                    current = current.Next;
                }
                current.Next = current.Next.Next;
                Count--;
            }
        }
        public void DeleteFirst() {
            if (Head != null) {
                Head = Head.Next;
                Count--;
            }
        }
        public void DeleteLast() {
            if (Tail != null) {
                var current = Head;
                while(current != null)
                {
                    if (current.Next.Equals(Tail)) {
                        current.Next = null;
                        Tail = current;
                        Count--;
                        return;
                    }
                    current=current.Next;
                }
            }
        }
        public void ChangeElement(int index,T data) {
            
            if (Head != null)
            {
                if (index < 0) throw new ArgumentOutOfRangeException();
                var current = Head;
                for (int i = 0; i < index; i++)
                {
                    if (current.Next == null)
                        throw new ArgumentOutOfRangeException();
                    current = current.Next;
                }
                current.Data = data;
            }
        }
        public bool IsEmpty() {
            return Head == null ?  true :  false;
        }
        
        public void Clear() {
            DeleteAll();    
        }
        public void AddList(LinkedList<T> list) {
            if (Head != null && list.Head != null)
            {
                Count+=list.Count;
                Tail.Next = list.Head;
                Tail = list.Tail;

            }
            
        }
        private void DeleteAll() {
            Head = null;
            Tail = null;
            Count = 0;
        }
        private void SetHeadAndTail(T data) {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        public override string ToString()
        {
            return "Linked List" + Count + " элементов ";
        }
    }
}
