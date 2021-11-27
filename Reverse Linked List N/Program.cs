using System;

public class LinkedList
{

    static Node head;

    class Node
    {

        public int data;
        public Node next, prev;

        public Node(int d)
        {
            data = d;
            next = prev = null;
        }
    }


    void reverse()
    {
        Node temp = null;
        Node current = head;


        while (current != null)
        {
            temp = current.prev;
            current.prev = current.next;
            current.next = temp;
            current = current.prev;
        }


        if (temp != null)
        {
            head = temp.prev;
        }
    }


    void push(int new_data)
    {


        Node new_node = new Node(new_data);


        new_node.prev = null;


        new_node.next = head;


        if (head != null)
        {
            head.prev = new_node;
        }


        head = new_node;
    }


    void printList(Node node)
    {
        while (node != null)
        {
            Console.Write(node.data + " ");
            node = node.next;
        }
    }


    public static void Main(String[] args)
    {
        LinkedList list = new LinkedList();


        list.push(27);
        list.push(20);
        list.push(18);
        list.push(7);
        list.push(5);
        list.push(1);

        Console.WriteLine("Original linked list ");
        list.printList(head);

        list.reverse();
        Console.WriteLine("");
        Console.WriteLine("The reversed Linked List is ");
        list.printList(head);
    }
}