using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next !=null)
                {
                    temp = temp.next;
                }
                temp.next= node;
            }
            Console.WriteLine("{0} Inserted into Linked List",node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("LinkList Is Empty");
                return;
            }
            while (temp!=null)
            {
                Console.Write(temp.data + " ");
                temp=temp.next;
            }
        }
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data); // (56,null)
            if (head == null)
            {
                head = newNode; // (70,null)
            }
            else
            {
                Node temp = head;// (30,next)->(70,null)
                head = newNode;//(56,null)
                head.next = temp;//(56,next)->(30,next)->(70,null)
            }
        }
        public Node InsertAtParticularPosition(int position, int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                return newNode;
            }
            if (position == 0)
            {
                newNode.next = head;
                head = newNode;
                return head;
            }
            Node prev = null;
            Node current = head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newNode.next = prev.next;
            prev.next = newNode;
            Console.WriteLine("Inserted value is: " + head);
            return head;
        }
    }
}
