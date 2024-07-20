using System.Collections;
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

        public static TreeNode DepthFirstSearch(TreeNode root, int key)
        {
            // Depth First Search (DFS) - поиск в глубину, для графа или дерева
            if(root == null || root.Key == key)
            {
                return root;
            }

            if(key > root.Key)
            {
                return DepthFirstSearch(root.Right, key);
            } 
            
            
            return DepthFirstSearch(root.Left, key);
            
        }

        public static TreeNode BreadthFirstSearch(TreeNode root, int key)
        {
            // Breadth First Search (BFS) - поиск в ширину, для графа или дерева. Проверяем постепенно по уровням.
            if(root == null)
            {
                return root;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();

                if(current.Key == key)
                {
                    return current;
                }

                if(current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if(current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

            return null;
        }

        public static TreeNode Delete(TreeNode root, int key)
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

            PrintInorder(root.Left);
            Console.Write(root.Key.ToString() + " ");
            PrintInorder(root.Right);
        }

        public static void PrintPreorder(TreeNode root)
        {
            if(root == null)
            {
                return;
            }

            Console.Write(root.Key.ToString() + " ");
            PrintPreorder(root.Left);
            PrintPreorder(root.Right);
        }

        public static void PrintPostorder(TreeNode root)
        {
            if(root == null)
            {
                return;
            }

            PrintPostorder(root.Left);
            PrintPostorder(root.Right);
            Console.Write(root.Key.ToString() + " ");
        }
    }
}
