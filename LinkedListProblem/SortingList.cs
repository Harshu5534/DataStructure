using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class SortingList<T>where T:IComparable<T>
    {
        public class Node<T>
        {
            public T data;
            public Node<T> next;
            public Node(T value)
            {
                data = value;
                next = null;
            }
        }
        public Node<T> head = null;
        public Node<T> tail = null;
        public void AddNode(T data)
        {
                //Create a new node  
            Node<T> newNode = new Node<T>(data);
            //Checks if the list is empty
            if (head == null)
            {
                //If list is empty, both head and tail will point to new node  
                head = newNode;
                //tail = newNode;
            }
            else
            {
                //newNode will be added after tail such that tail's next will point to newNode  
                //head.next = newNode;
                //newNode will become new tail of the list  
                //head = newNode;
                 Node<T> temp = head;
                 while (temp.next != null)
                 {
                    temp = temp.next;
                 }
                 temp.next = newNode;
            }
        }
        public void SortOrderedList()
        {
            //Node current will point to head  
            Node<T> current = head, index = null;
            T temp;
            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    //Node index will point to node next to current  
                    index = current.next;
                    while (index != null)
                    {
                        //If current node's data is greater than index's node data, swap the data between them  
                        if (current.data.CompareTo(index.data) > 0)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
        public void DisplaySort()
        {
                //Node current will point to head  
             Node<T> current = head;
             if (head == null)
             {
                Console.WriteLine("List is empty");
                return;
             }
             while (current != null)
             {
                    //Prints each node by incrementing pointer  
                Console.Write(current.data + " ");
                current = current.next;
             }
             Console.WriteLine();
        }

    }
}
