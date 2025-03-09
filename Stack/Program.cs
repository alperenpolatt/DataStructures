using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

StackYapisi stc = new StackYapisi();
int sayi;
int secim = menu();
while (secim!=0)
{
	switch (secim)
	{
		case 1:
			Console.WriteLine("Sayı: "); sayi = int.Parse(Console.ReadLine());
			stc.push(sayi);break;
		case 2:
			sayi = stc.pop();
			if (sayi!=1)
			{
				Console.WriteLine("Çıkan sayı:"+sayi);
			}
			else
			{
				Console.WriteLine("Stack boştu");
			}
			break;
		case 3:
			Console.Clear(); stc.print();break;
		case 4: 
			stc.topPrint();break;
		case 0: break;
		default:
			Console.WriteLine("Hatalı seçim");
			break;
	}
	secim = menu();
}

Console.ReadKey();

static int menu()
{
	int secim;
	Console.WriteLine("1-push");
	Console.WriteLine("2-pop");
	Console.WriteLine("3-print");
	Console.WriteLine("4-top");
	Console.WriteLine("0-exit");
	secim = int.Parse(Console.ReadLine());
	return secim;
}
class Node
{
	public int data;
	public Node next;
	public Node(int data)
	{
		this.data = data;
		next = null;
	}
}
class StackYapisi {
	Node top;
	public StackYapisi()
	{
		top = null;
	}
	public void push(int data)
	{
		Node eleman = new Node(data);
		if (top==null)
		{
			top = eleman;
			Console.WriteLine("Stack yapısı oluşturuldu, ilk eleman stack'e girdi");
		}
		else
		{
			eleman.next = top;
			top = eleman;
			Console.WriteLine("eleman eklendi");
		}
	}
	public int pop()
	{
		if (top==null)
		{
			Console.WriteLine("Stack boş!");
			return -1;
		}
		else
		{
			int sayi = top.data;
			top = top.next;
			Console.WriteLine(sayi+" stackden çıkartıldı");
			return sayi;
		}

	}
	public void print()
	{
		if (top==null)
		{
			Console.WriteLine("Stack boş!");
		}
		else
		{
			Node temp = top;
			Console.Clear();
			while (temp!=null)
			{
				Console.WriteLine(temp.data+",");
				temp = temp.next;
			}

		}
	}
	public void topPrint()
	{
		if (top==null)
		{
			Console.WriteLine("Stack boş!");
		}
		else
		{
			Console.WriteLine(top.data);
		}
	}
}
