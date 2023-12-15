using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAlgoritmos
{
    public class BinaryTree
    {
        private TreeNode root;

        public void Insert(int data)
        {
            root = InsertRecursive(root, data);
        }

        private TreeNode InsertRecursive(TreeNode root, int data)
        {
            if (root == null)
            {
                return new TreeNode(data);
            }

            if (data < root.Data)
            {
                root.Left = InsertRecursive(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = InsertRecursive(root.Right, data);
            }

            return root;
        }

        public List<int> InOrderTraversal()
        {
            List<int> result = new List<int>();
            InOrderTraversalRecursive(root, result);
            return result;
        }

        private void InOrderTraversalRecursive(TreeNode root, List<int> result)
        {
            if (root != null)
            {
                InOrderTraversalRecursive(root.Left, result);
                result.Add(root.Data);
                InOrderTraversalRecursive(root.Right, result);
            }
        }
    }
}
