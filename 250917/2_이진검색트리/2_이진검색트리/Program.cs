namespace _2_이진검색트리
{
    class BSTNode
    {
        public int Key;
        public BSTNode Left;
        public BSTNode Right;

        public BSTNode(int Key)
        {
            this.Key = Key;
        }
    }

    class BinarySearchTree
    {
        private BSTNode _root;

        public void Insert(int key)
        {
            //

            _root = InsertRec(_root, key);
        }

        private BSTNode InsertRec(BSTNode node, int key) 
        {
            BSTNode bst;

            if (node == null)
            {
                bst = new BSTNode(key);
                node = bst;
            }
            else if(node.Key < key)
            {
                if (node.Right != null)
                {
                    InsertRec(node.Right, key);
                }
                else
                {
                    bst = new BSTNode(key);
                    node.Right = bst;
                }
                
            }
            else if (node.Key > key)
            {
                if (node.Left != null)
                {
                    InsertRec(node.Left, key);
                }
                else
                {
                    bst = new BSTNode(key);
                    node.Left = bst;
                }
            }

            return node;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree b = new BinarySearchTree();

            b.Insert(0);
            b.Insert(1);
            b.Insert(2);
            b.Insert(-1);
        }
    }
}
