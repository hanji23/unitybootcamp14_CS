namespace _1__트리
{
    class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();


    }
    internal class Program
    {
        static TreeNode<string> MakeTree()
        {
            TreeNode<string> root = new TreeNode<string>() { Data = "A" };
            {
                TreeNode<string> nodeB = new TreeNode<string>() { Data = "B" };
                {
                    TreeNode<string> nodeD = new TreeNode<string>() { Data = "D" };
                    {
                        TreeNode<string> nodeH = new TreeNode<string>() { Data = "H" };
                        TreeNode<string> nodeI = new TreeNode<string>() { Data = "I" };

                        nodeD.Children.Add(nodeH);
                        nodeD.Children.Add(nodeI);
                    }
                    TreeNode<string> nodeE = new TreeNode<string>() { Data = "E" };

                    nodeB.Children.Add(nodeD);
                    nodeB.Children.Add(nodeE);
                }
                TreeNode<string> nodeC = new TreeNode<string>() { Data = "C" };
                {
                    TreeNode<string> nodeF = new TreeNode<string>() { Data = "F" };
                    TreeNode<string> nodeG = new TreeNode<string>() { Data = "G" };

                    nodeC.Children.Add(nodeF);
                    nodeC.Children.Add(nodeG);
                }

                root.Children.Add(nodeB);
                root.Children.Add(nodeC);
            }

            return root;
        }


        static void PrintTree(TreeNode<string> node)
        {
            Console.WriteLine(node.Data);

            foreach (TreeNode<string> child in node.Children)
            {
                PrintTree(child);
            }
        }

        static int GetHeight(TreeNode<string> node)
        {
            int height = 0;

            foreach (TreeNode<string> child in node.Children)
            {
                int nextheight = GetHeight(child) + 1;

                if (nextheight > height)
                    height = nextheight;

            }
            return height;
        }

        static void Main(string[] args)
        {
            var root = MakeTree();
            Console.WriteLine(GetHeight(root));

        }
    }
}
