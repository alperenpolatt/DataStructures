QueueYapisi q1 = new QueueYapisi();
q1.enQueue(10);
q1.enQueue(20);
int sayi = q1.deQueue();
Console.WriteLine(sayi);
q1.enQueue(5);
q1.print();
class Node
{
	public int data;
	public Node next;
	public Node(int data)
	{
		this.data = data;
		this.next = null;
	}
}
class QueueYapisi
{
	Node front;
	Node rear;
	public QueueYapisi()
	{
		this.front = null;
		this.rear = null;
	}
	public void enQueue(int data)
	{
		Node eleman = new Node(data);
		if (front==null)
		{
			front = rear = eleman;
			Console.WriteLine("Kuyruk yapısı oluşturuldu ilk eleman eklendi");
		}
		else
		{
			rear.next = eleman;
			rear = eleman;
			Console.WriteLine("Ekleme yapıldı");
		}
	}
	public int deQueue()
	{
		if (front==null)
		{
			Console.WriteLine("Liste boş");
			return -1;
		}
		else
		{
			var data = front.data;
			front = front.next;
			Console.WriteLine("Kuyruktan eleman çıkarıldı");
			return data;
		}
	}
	public void print()
	{
		if (front == null)
		{
			Console.WriteLine("Liste boş");
		}
		else
		{
			Node temp = front;
			while (temp!=null)
			{
				Console.WriteLine(temp.data + " <- ");
				temp = temp.next;
			}
		}
	}

}