using System;

namespace HashTable;

public class Tablo
{
    public int size;
    public Node [] dizi;
    public Tablo(int size)
    {
        this.size=size;
        dizi = new Node[size];
        for (int i = 0; i < size; i++)
        {
            dizi[i]= new Node();
        }
    }
    int indexUret(int key){
        return key % size;
    }
    public void ekle(int key, string isim){
        Node eleman = new Node(key,isim);
        int indis = indexUret(key);
        Node temp=dizi[indis]; //Sona ekle
        while (temp.next!=null)
        {
            temp=temp.next;
        }
        temp.next=eleman;

        //SONA EKLER
        /*
        eleman.next=dizi[indis].next;
        dizi[indis].next=eleman;*/


        //System.Console.WriteLine(isim+" eklendi");
    }
    public void yazdir(){
        for (int i = 0; i < size; i++)
        {
            Console.Write("dizi["+i.ToString()+"]->");
            Node temp = dizi[i].next;
            while (temp!=null)
            {
                System.Console.Write(","+temp.isim);
                temp=temp.next;
            }
            System.Console.WriteLine();
        }
    }

      public void sil(int key){
        var index = indexUret(key);
        if (dizi[index].next==null)
        {
            System.Console.WriteLine("Numaralı kayıt yok");
        }
        else if(dizi[index].next.key==key){//İlk elemansa
            dizi[index].next=dizi[index].next.next;
        }
        else{
            Node temp =dizi[index].next;
            Node previousTemp =temp;
            while (temp!=null)
            {
                if (temp.key==key)
                {
                    previousTemp.next=temp.next;
                    break;
                }
                previousTemp=temp;
                temp=temp.next;
            }
        }
    }
}
