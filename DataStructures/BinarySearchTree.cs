using System.Xml.Linq;

namespace DataStructures
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; private set; } = null;

        public void Insert(int key) 
        {
            Root = BinarySearchTree.InsertItem(Root, key);
        }

        private static TreeNode InsertItem(TreeNode node, int key)
        {
            TreeNode newNode = new TreeNode(key);

            if(node == null)
            {
                node = newNode;
                return node;
            }

            if(key < node.Key)
            {
                node.Left = InsertItem(node.Left, key);
            }
            else
            {
                node.Right = InsertItem(node.Right, key);
            }

            return node;
        }

        public TreeNode Search(TreeNode root, int key)
        {
            if(root == null || root.Key == key)
            {
                return root;
            }

            if(key > root.Key)
            {
                return Search(root.Right, key);
            } 
            
            
            return Search(root.Left, key);
            
        }

        public TreeNode Delete(TreeNode root, int key)
        {
            if(root == null)
            {
                return root;
            }

            if(key < root.Key)
            {
                root.Left = Delete(root.Left, key);
            } 
            else if(key > root.Key)
            {
                root.Right = Delete(root.Right, key);
            }
            else
            {
                if(root.Left == null)
                {
                    return root.Right;
                }
                else if(root.Right == null)
                {
                    return root.Left;
                }

                root.Key = BinarySearchTree.MinValue(root.Right);
                root.Right = Delete(root.Right, root.Key);
            }

            return root;
        }

        private static int MinValue(TreeNode root)
        {
            int minv = root.Key;
            while (root.Left != null)
            {
                minv = root.Left.Key;
                root = root.Left;
            }
            return minv;
        }

        public static void PrintInorder(TreeNode root)
        {
            if(root == null)
            {
                return;
            }

            BinarySearchTree.PrintInorder(root.Left);
            Console.Write(root.Key.ToString() + " ");
            BinarySearchTree.PrintInorder(root.Right);
        }
    }
}
