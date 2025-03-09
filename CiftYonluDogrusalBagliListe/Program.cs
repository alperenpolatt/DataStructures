using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

Liste cydbl = new Liste();
cydbl.sonaEkle(10);
cydbl.sonaEkle(20);
cydbl.sonaEkle(30);
cydbl.arayaEkle(1, 15);
cydbl.yazdir();
cydbl.aradanSil(1);
cydbl.yazdir();
class Node
{
	public int data;
	public Node next;
	public Node prev;
	public Node(int data)
	{
		this.data = data;
		this.next = null;
		this.prev = null;
	}
}
class Liste {
	public Node head;
	public Node tail;
	public Liste()
	{
		head = null;
		tail = null;
	}
	public void basaEkle(int data)
	{
		Node eleman = new Node(data);
		if (head==null)
		{
			head = tail = eleman;
		}
		else
		{
			eleman.next = head;
			head.prev = eleman;
			head = eleman;
		}
	}
	public void sonaEkle(int data)
	{
		Node eleman = new Node(data);
		if (head==null)
		{
			head = tail = eleman;
		}
		else
		{
			tail.next = eleman;
			eleman.prev = tail;
			tail = eleman;
		}
	}
	public void yazdir()
	{
		if (head == null)
		{
			Console.WriteLine("Liste boş");
		}
		else
		{
			Node temp = head;
			while (temp != null)
			{
				Console.Write(temp.data+",");
				temp = temp.next;
			}
			Console.WriteLine();
		}
	}

	public void bastanSil()
	{
		if (head == null)
		{
			Console.WriteLine("Liste boş");
		}
		else if (head.next == null)
		{
			head = tail = null;
		}
		else
		{
			head = head.next;
		}
	}

	public void sondanSil()
	{
		if (head == null)
		{
			Console.WriteLine("Silinecek eleman yok");
		}
		else if (head.next == null)
		{
			head = tail = null;
		}
		else
		{
			tail = tail.prev;
			tail.next = null;
		}
	}
	public void arayaEkle(int index, int data)
	{
		Node eleman = new Node(data);
		if (head == null && index == 0)
		{
			basaEkle(data);
		}
		else
		{
			var temp = head;
			for (int i = 0; i < index - 1; i++)
			{
				temp = temp.next;
			}
			var temp2 = new Node(temp.data);
			temp2.next = temp.next;

			temp.next = eleman;
			eleman.next = temp2.next;
			eleman.prev = temp;
		}
	}

	public void aradanSil(int index)
	{
		if (head == null)
			Console.WriteLine("liste boş");
		else if (head.next == null && index == 0)
		{
			head = tail = null;
			Console.WriteLine("Listede kalan son düğümde silindi");
		}
		else if (head.next != null && index == 0)
		{
			bastanSil();
		}
		else
		{
			int i = 0;
			Node temp = head;
			Node temp2 = temp;
			while (temp.next != null)
			{
				if (i == index)
				{
					temp2.next = temp.next;
					temp.next.prev = temp2;
					Console.WriteLine("aradan düğüm silindi");
					i++;
					break;
				}
				temp2 = temp;
				temp = temp.next;
				i++;
			}
			if (i == index)
			{
				sondanSil();
			}
		}
	}

}