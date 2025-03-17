using System;

namespace HashTable;

public class Node
{
    public int key;
    public  string isim;
    public Node next;
    public Node()
    {
        this.next=null;
    }
    public Node(int key,string isim)
    {
        this.key=key;
        this.isim=isim;
        this.next=null;
    }
}
