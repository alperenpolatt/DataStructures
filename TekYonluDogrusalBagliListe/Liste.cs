using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TekYonluDogrusalBagliListe
{
	public class Liste
	{
		public Node head;
		public Liste()
		{
			head = null;
		}
		public void sonaEkle(int data)
		{
			Node eleman = new Node(data);
			if (head==null)
			{
				head = eleman;
			}
			else
			{
				Node temp = head;
				while (temp.next!=null)
				{
					temp = temp.next;
				}
				temp.next = eleman;
			}
		}
		public void basaEkle(int data)
		{
			Node eleman = new Node(data);
			if (head == null)
			{
				head = eleman;
			}
			else
			{
				eleman.next = head;
				head = eleman;
			}
		}
		public void yazdir()
		{
			Node temp = head;
			if (temp == null)
			{
				Console.WriteLine("Liste boş");
				return;
			}
			while (temp != null)
			{
				Console.Write(temp.data + "->");
				temp = temp.next;
			}
		}
		public void bastanSil()
		{
			if (head == null)
			{
				Console.WriteLine("Liste boş");
			}
			else
			{
				head = head.next;
				Console.WriteLine("Baştaki eleman silindi");
			}
		}

		public void sondalSil()
		{
			if (head==null)
			{
				Console.WriteLine("Liste boş");
			}
			else
			{
				var temp = head;
				while (temp.next.next!=null)
				{
					temp = temp.next;
				}
				temp.next = null;
			}
		}
		public void arayaEkle(int index,int data)
		{
			Node eleman = new Node(data);
			if (head==null && index==0)
			{
				basaEkle(data);
			}
			else
			{
				var temp = head;
				for (int i = 0; i < index-1; i++)
				{
					temp=temp.next;
				}
				var temp2 = new Node(temp.data);
				temp2.next = temp.next;

				temp.next = eleman;
				eleman.next = temp2.next;
			}
		}
		public void aradanSil(int index)
		{
			if (head == null )
			{
				Console.WriteLine("Hiç Eleman yok");
			}
			else if(head!=null && index == 0)
			{
				bastanSil();
			}
			
			else
			{
				var temp = head;
				for (int i = 0; i < index - 1; i++)
				{
					temp = temp.next;
				}
				temp.next = temp.next.next;
			}
		}
	}
}
