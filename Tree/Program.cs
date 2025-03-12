
//Kendisinden küçük değerler node'un soluna eklenecek büyük değerler ağacın sağına eklenecek
//BINARY SEARCH TREE
using System;

Console.WriteLine("AĞAÇ VERİ YAPISI");

Tree bst = new Tree();
bst.root =bst.insert(bst.root,10);
bst.root =bst.insert(bst.root,5);
bst.root =bst.insert(bst.root,15);
bst.root =bst.insert(bst.root,20);
bst.root =bst.insert(bst.root,3);
bst.root =bst.insert(bst.root,12);
bst.root =bst.insert(bst.root,9);

System.Console.WriteLine("\npreOrder:   ");
bst.preOrder(bst.root);
System.Console.WriteLine("\ninOrder:   ");
bst.inOrder(bst.root);
System.Console.WriteLine("\npostOrder:   ");
bst.postOrder(bst.root);

System.Console.WriteLine("\neleman sayısı:   "+bst.size(bst.root));
System.Console.WriteLine("Yükseklik:   "+bst.height(bst.root));
class Node{
    public int data;
    public Node left;
    public Node right;
    public Node(int data)
    {
        this.data=data;
        left=null;
        right=null;
    }
}
class Tree{
    public Node root;
    public Node newNode(int data){
        root= new Node(data);
        return root;
    }
    public Node insert(Node root,int data){
        Node eleman = new Node(data);
        if (root!=null)
        {
            if(data<root.data)
                root.left=insert(root.left,data);
            else
                root.right=insert(root.right,data);
        }
        else
            root=newNode(data);
        return root;
    }
    public void preOrder(Node root){ //Önce köke uğra
        if (root!=null)
        {
            System.Console.Write(root.data+"    ");
            preOrder(root.left);
            preOrder(root.right);
        }
    }
    public void inOrder(Node root){//ortada köke uğra

         if (root!=null)
        {
            inOrder(root.left);
            System.Console.Write(root.data+"    ");
            inOrder(root.right);
        }

    }
    public void postOrder(Node root){//sonda köke uğra
        if (root!=null)
        {
            postOrder(root.left);
            postOrder(root.right);
            System.Console.Write(root.data+"    ");
        }

    }
    public int size(Node root){
        if (root ==null)
        {
            return 0;
        }
        else{
            return size(root.left) + 1 + size(root.right);
        }
    }
    public int height(Node root){
        if (root==null)
        {
            return -1;
        }
        else{
            int l,r;
            l=height(root.left);
            r=height(root.right);
            if(l>r)
                return l+1;
            else
                return r+1;
        }
    }
    
}