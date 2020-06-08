using System;

class Program
{
    static void Main(string[] args)
    {
        BinaryTree bt = new BinaryTree();
        /// NOTE: this program is not meant to 
        /// implement the whole functionallity of a Binary Tree)
        /// but rather to be implemented under 35 minutes
        /// as per the requested problem described under the Readme.md file.
        /// SAMPLE CASE:
        bt.Root = new Node(8);
        bt.Root.LeftNode = new Node(3);
        bt.Root.LeftNode.LeftNode = new Node(1);
        bt.Root.LeftNode.RightNode = new Node(6);
        bt.Root.LeftNode.RightNode.LeftNode = new Node(4);
        bt.Root.LeftNode.RightNode.RightNode = new Node(7);
        bt.Root.RightNode = new Node(10);
        bt.Root.RightNode.RightNode = new Node(14);
        bt.Root.RightNode.RightNode.LeftNode = new Node(13);

        Console.WriteLine(bt.visibleNodes(bt.Root));
    }
}
class Node
{
    public Node LeftNode { get; set; }
    public Node RightNode { get; set; }
    public int Data { get; set; }
    public Node(int value)
    {
        this.Data = value;
        Console.WriteLine($" Creating Node with value {value}");
    }
}


class BinaryTree
{
    public Node Root { get; set; }
    public int visibleNodes(Node root)
    {
        int totalNodes = 0;
        if (root.LeftNode != null)
        {
            totalNodes = countLeftNodes(root) + 1;
        }
        return totalNodes;
    }
    public int countLeftNodes(Node node)
    {
        int count = 0;
        if (node.LeftNode != null)
            count += 1 + countLeftNodes(node.LeftNode);

        if (node.LeftNode != null)
            count += countLeftNodes(node.RightNode);
        return count;
    }
}

