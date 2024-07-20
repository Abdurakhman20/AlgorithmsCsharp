namespace DataStructures
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;

        public void Insert(int key)
        {
            Root = InsertItem(Root, key);
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
    }
}
