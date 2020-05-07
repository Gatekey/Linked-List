using System;
using System.Collections.Generic;
using System.Xml;

namespace DoublyLinkedList
{
    class Program
    {
      
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.InsertFirst(list, 5);
            Console.WriteLine(list.head.data);
            Node one =new Node(4);

        }
    } 
    public class Node 
    {
        public int data;
        public Node next;
        public  Node prev;
        public Node(int d) 
        {
            data = d;
            prev = null;
            next = null;
        }
    }
    public class DoublyLinkedList 
    {
        public Node head;
        internal void InsertFront(DoublyLinkedList doubleLinkedList, int data)
        {
            Node newNode = new Node(data);
            newNode.next = doubleLinkedList.head;
            newNode.prev = null;
            if (doubleLinkedList.head != null)
            {
                doubleLinkedList.head.prev = newNode;
            }
            doubleLinkedList.head = newNode;
        }
        public void InsertFirst(DoublyLinkedList dlist,int data) 
        {
            Node new_node =new Node(data);
           
            if(dlist.head!=null)
            {
                dlist.head.prev = new_node;
                new_node.next = dlist.head;
                
            }
            dlist.head = new_node; 

        }

        public void InsertAfter(Node prev,int data)
        {
            if(prev == null)
            {
                return;
            }
            Node next = prev.next;
            Node new_node = new Node(data);
            prev.next = new_node;
            new_node.prev = prev;
            new_node.next = next;
            if(next != null)
            {
                next.prev = new_node;
            }
        }

        public Node GetLastNode(DoublyLinkedList dlist)
        {
            if(dlist.head == null)
            {
                return null;
            }
            Node temp = dlist.head.next;
            while (temp.next != null) 
            {
                temp = temp.next;
            }
            return temp;
        }
        public void InsertLast(DoublyLinkedList dlist,int data)
        {
            Node new_node = new Node(data);
            if(dlist.head == null)
            {
                dlist.head = new_node;
            }
            Node last = GetLastNode(dlist);
            if (last.prev != null)
            {
                last.prev.next = new_node;
            }
            new_node.prev = last.prev;
            new_node.next = last;
            last.prev = new_node;
        }

        public void DeleteNode(Node nodetodelete)
        {
            if(nodetodelete == null)
            {
                return;
            }
            if (nodetodelete.prev != null)
            {
                nodetodelete.prev.next = nodetodelete.next;
            }
            if (nodetodelete.next != null)
            {
                nodetodelete.next.prev = nodetodelete.prev;
            }
        }
    }
}
