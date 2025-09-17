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
                        nodeD.Children.Add(new TreeNode<string>() { Data = "H" });
                        nodeD.Children.Add(new TreeNode<string>() { Data = "I" });
                        //TreeNode<string> nodeH = new TreeNode<string>() { Data = "H" };
                        //TreeNode<string> nodeI = new TreeNode<string>() { Data = "I" };
                    }
                    TreeNode<string> nodeE = new TreeNode<string>() { Data = "E" };

                    nodeB.Children.Add(nodeD);
                    nodeB.Children.Add(nodeE);
                }

                TreeNode<string> nodeC = new TreeNode<string>() { Data = "C" };
                {
                    nodeC.Children.Add(new TreeNode<string>() { Data = "F" });
                    nodeC.Children.Add(new TreeNode<string>() { Data = "G" });
                    //TreeNode<string> nodeD = new TreeNode<string>() { Data = "F" };
                    //TreeNode<string> nodeE = new TreeNode<string>() { Data = "G" };
                }

                root.Children.Add(nodeB);
                root.Children.Add(nodeC);
            }
            return root;
        }

        static void PrintTree(TreeNode<string> node)
        {
            Console.WriteLine(node.Data);

            if (node.Children.Count > 0)
            {
                foreach( TreeNode<string> child in node.Children)
                {
                    PrintTree(child);
                }
            }
        }

        static void Main(string[] args)
        {
            var root = MakeTree();
            PrintTree(root);

        }
    }
}
