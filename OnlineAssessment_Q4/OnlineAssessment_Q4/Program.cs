using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAssessment_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 51, 31, 22, 17, 12, 9, 18, 0 };
			MaxHeap heap1 = new MaxHeap();

			
			heap1.insert(51);
			heap1.insert(31);
			heap1.insert(22);
			heap1.insert(17);
			heap1.insert(12);
			heap1.insert(9);
			heap1.insert(18);
			heap1.insert(0);



			heap1.preorder(heap1.root);
			
			//4.2.
			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("4.2.a Inserting 68");
			Console.WriteLine("");

			heap1.insert(68);

			heap1.preorder(heap1.root);



			Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("4.2.b Array representation");
			Console.WriteLine("");

			arr[arr.Length - 1] = 68;

			for (int i = 0;i<arr.Length;i++)
			{
				Console.Write(""+arr[i]+",");
			}





			/*
			MaxHeap heap2 = new MaxHeap();
			

			for (int i = 15; i > 0; i--)
			{
				heap2.insert(i);
			}
			Console.WriteLine();
			heap2.preorder(heap2.root);

			Console.ReadLine();
			*/
			Node nde=heap1.root;
			deleteRoot(arr,nde.key);




			Console.ReadLine();

			//4.4. The complexity is quite high



		}



		static void heapify(int[] arr, int n, int i)
		{
			int largest = i; // Initialize largest as root
			int l = 2 * i + 1; // left = 2*i + 1
			int r = 2 * i + 2; // right = 2*i + 2


			if (l < n && arr[l] > arr[largest])
				largest = l;


			if (r < n && arr[r] > arr[largest])
				largest = r;


			if (largest != i)
			{
				int swap = arr[i];
				arr[i] = arr[largest];
				arr[largest] = swap;


				heapify(arr, n, largest);
			}
		}


		static int deleteRoot(int[] arr, int n)
		{

			int lastElement = arr[n - 1];


			arr[0] = lastElement;


			n = n - 1;


			heapify(arr, n, 0);


			return n;
		}







	}







	public class Node
	{
		//Left and right child
		public Node left;
		public Node right;
		//Data value
		public int key;
		public Node(int key)
		{
			this.key = key;
			left = null;
			right = null;
		}
	}
	public class MaxHeap
	{
		//This is use to store information of number of nodes in Max heap
		public int size;
		public Node root;
		public MaxHeap()
		{
			root = null;
			size = 0;
		}
		//Get height of insert new node
		public int insertHeight()
		{
			int i = 1;
			int sum = 0;
			while (this.size > sum + (1 << i))
			{
				sum += (1 << i);
				i++;
			}
			return i;
		}
		public void swapNode(Node first, Node second)
		{
			int key = first.key;
			first.key = second.key;
			second.key = key;
		}
		//Arrange node key
		public void arrangeNode(Node root)
		{
			if (root.left != null && root.left.key > root.key)
			{
				swapNode(root, root.left);
			}
			if (root.right != null && root.right.key > root.key)
			{
				swapNode(root, root.right);
			}
		}
		public Boolean addNode(Node root, int height, int level, int key)
		{
			if (level >= height)
			{
				return false;
			}
			if (root != null)
			{
				if (level - 1 == height && root.left == null || root.right == null)
				{
					if (root.left == null)
					{
						root.left = new Node(key);
					}
					else
					{
						root.right = new Node(key);
					}
					arrangeNode(root);
					return true;
				}
				if (addNode(root.left, height, level + 1, key) ||
					addNode(root.right, height, level + 1, key))
				{
					arrangeNode(root);
					return true;
				}
			}
			return false;
		}
		//Handles the request to new inserting node
		public void insert(int key)
		{
			//Test case

			if (root == null)
			{
				root = new Node(key);
			}
			else
			if (root.left == null)
			{
				root.left = new Node(key);
				arrangeNode(root);
			}
			else
			if (root.right == null)
			{
				root.right = new Node(key);
				arrangeNode(root);
			}
			else
			{
				int height = insertHeight();
				addNode(root, height, 0, key);
			}
			this.size++;
		}
		public void preorder(Node root)
		{
			if (root != null)
			{
				Console.Write(" " + root.key);
				preorder(root.left);
				preorder(root.right);
			}
		}

	}



}

