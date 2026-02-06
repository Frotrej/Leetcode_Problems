using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leetcode_pomoc
{
	internal class BinaryTreeInorderTraversal
	{
		List<int> solu = new List<int>();

		public IList<int> BinaryTreeInorderTraversalMethod(TreeNode root)
		{

			if (root == null) return solu;

			Travers(root);

			return solu;
		}

		public void Travers(TreeNode root)
		{
			if (root.left != null) Travers(root.left);

			solu.Add(root.val);

			if (root.right != null) Travers(root.right);
		}

	}
	//Definition for a binary tree node.
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}

}

