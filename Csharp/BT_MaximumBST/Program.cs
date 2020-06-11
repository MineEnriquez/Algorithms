using System; 

// C# program to find largest BST subtree in given Binary Tree 

public class Node 
{ 

	public int data; 
	public Node left, right; 

	public Node(int d) 
	{ 
		data = d; 
		left = right = null; 
	} 
} 

public class Value 
{ 

	public int max_size = 0; // for size of largest BST 
	public bool isBST = false; 
	public int min = int.MaxValue; // For minimum value in right subtree 
	public int max = int.MinValue; // For maximum value in left subtree 

} 

public class BinaryTree 
{ 
	public static Node root; 
	public Value BT_values = new Value(); 
	
    /// <summary>
	/// Largest BST method
	/// </summary>
	/// <param name="node"></param>
	/// <returns></returns>
    public virtual int largestBST(Node node) 
	{ 

		largestBSTUtil(node, BT_values, BT_values, BT_values, BT_values); 
		return BT_values.max_size; 
	} 

    /// <summary>
    /// Utility Method to find the Largest Binary Search SubTree - Recursive
    /// </summary>
    /// <param name="node"></param>
    /// <param name="curr_min"></param>
    /// <param name="curr_max"></param>
    /// <param name="curr_maxSize"></param>
    /// <param name="curr_isBST"></param>
    /// <returns></returns>
	public virtual int largestBSTUtil(Node node, Value curr_min, Value curr_max, Value curr_maxSize, Value curr_isBST) 
	{ 
		/* Base Case */
		if (node == null) { 
			curr_isBST.isBST = true;   // An empty tree is BST 
			return 0;                   // Size of the BST is 0 
		} 

		int min = int.MaxValue;             // set min to the MAXIMUM POSSIBLE VALUE for an int number??
		bool _left = false;                 // A flag variable for left subtree property  i.e., max(root->left) < root->data 
		bool _right = false;  	            // A flag variable for right subtree property  i.e., min(root->right) > root->data 
		int Left_SubTree_Size;              // To store sizes of left and right subtrees 
		int Right_SubTree_Size;             // To store size of right subtree

        curr_max.max = int.MinValue;        // Resets the value of curr_max.max OBJECT.
	
        //==> Enters RECURSION with LEFT CHILD
    	Left_SubTree_Size = largestBSTUtil(node.left, curr_min, curr_max, curr_maxSize, curr_isBST);  
		//<==== Comes back from RECURSION for LEFT CHILD

        if (curr_isBST.isBST == true && node.data > curr_max.max)  /* */ _left = true; 
        min = curr_min.min; 

		curr_min.min = int.MaxValue; 

         //==> Enters RECURSION with RIGHT CHILD
		Right_SubTree_Size = largestBSTUtil(node.right, curr_min, curr_max, curr_maxSize, curr_isBST); 
        // <==== Comes back from RECURSION for RIGHT CHILD
		if (curr_isBST.isBST == true && node.data < curr_min.min) /**/	_right = true; 

		// Update min and max values for the parent recursive calls 
		if (min < curr_min.min) 	     /**/   curr_min.min = min; 
		if (node.data < curr_min.min) /**/   curr_min.min = node.data; 
		if (node.data > curr_max.max) /**/   curr_max.max = node.data; 

		if (_left && _right) { 
			if (Left_SubTree_Size + Right_SubTree_Size + 1 > curr_maxSize.max_size) /**/ 	curr_maxSize.max_size = Left_SubTree_Size + Right_SubTree_Size + 1; 
			return Left_SubTree_Size + Right_SubTree_Size + 1; 
		} 
		else { 
			//Since this subtree is not BST, set isBST flag for parent calls 
			curr_isBST.isBST = false; 
			return 0; 
		} 
	} 


/// <summary>
/// Main
/// </summary>
/// <param name="args"></param>
	public static void Main(string[] args) 
	{ 
		/* Let us construct the following Tree 
				50 
			/	 \ 
			10	 60 
		/ \	 / \ 
		5 20 55 70 
		/	 / \ 
		45 65 80 
		*/

		BinaryTree tree = new BinaryTree(); 
		BinaryTree.root = new Node(50); 
		BinaryTree.root.left = new Node(10); 
		BinaryTree.root.right = new Node(60); 
		BinaryTree.root.left.left = new Node(5); 
		BinaryTree.root.left.right = new Node(20); 
		BinaryTree.root.right.left = new Node(55); 
		BinaryTree.root.right.left.left = new Node(45); 
		BinaryTree.root.right.right = new Node(70); 
		BinaryTree.root.right.right.left = new Node(65); 
		BinaryTree.root.right.right.right = new Node(80); 

		/* The complete tree is not BST as 45 is in right subtree of 50. 
		The following subtree is the largest BST 
			60 
			/ \ 
		55 70 
		/	 / \ 
		45	 65 80 
		*/
		Console.WriteLine("Size of largest BST is " + tree.largestBST(root)); 
	} 
} 

// This code is contributed by Shrikant13 
