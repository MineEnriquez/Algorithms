// We don’t provide test cases in this language yet. Please write your code below, and don’t forget to test edge cases!using 

using System;
using System.Collections;

class Program{
  static void Main(){
     Console.WriteLine("Test")  ;
     BinaryTree bt = new BinaryTree(12);
     
  }
}

class Node
{ public Node Left { get; set;}
  public Node Right  { get; set;}
  public int Data  { get; set;}
  public Node (int data) {
   this.Data = data;  
   Console.WriteLine(this.Data);
  }
}

class BinaryTree
{
  public Node Root {get; set;}
  public BinaryTree(int _rootNode){
    this.Root = new Node(_rootNode);    
  }
}