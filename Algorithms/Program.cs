using System.Collections;

namespace Algorithms 
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataStructures.BinarySearchTree bst = new DataStructures.BinarySearchTree();

            bst.Insert(20);
            bst.Insert(15);
            bst.Insert(14);
            bst.Insert(16);
            bst.Insert(30);
            bst.Insert(35);
            bst.Insert(28);
            bst.Insert(32);
            bst.Insert(40);

            DataStructures.BinarySearchTree.PrintPreorder(bst.Root);
        }
    } 
}
