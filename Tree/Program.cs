
//Kendisinden küçük değerler node'un soluna eklenecek büyük değerler ağacın sağına eklenecek
//BINARY SEARCH TREE
using System;

Console.WriteLine("AĞAÇ VERİ YAPISI");

Tree bst = new Tree();
bst.root =bst.insert(bst.root,10);
bst.root =bst.insert(bst.root,15);
bst.root =bst.insert(bst.root,5);
bst.root =bst.insert(bst.root,3);
bst.root =bst.insert(bst.root,8);
Console.WriteLine("root: "+bst.root.data);
Console.WriteLine("root right: "+bst.root.right.data);
Console.WriteLine("root left: "+bst.root.left.data);
Console.WriteLine("root left of left: "+bst.root.left.left.data);
Console.WriteLine("root right of left: "+bst.root.left.right.data);
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
}