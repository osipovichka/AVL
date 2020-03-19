using AVLTreeNode;
using System;

namespace AVL
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> tree = new AVLTree<int>();

            int[] array = new int[] { 10, 3, 12, 2, 11, 4, 15 };
            for (int i = 0; i < array.Length; i++)
            {
                tree.Add(array[i]);
            }

            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }
        }
    }
}
