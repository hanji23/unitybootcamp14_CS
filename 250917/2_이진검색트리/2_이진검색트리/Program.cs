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

                node.Right = InsertRec(node.Right, key);

            }
            else if (node.Key > key)
            {

                node.Left = InsertRec(node.Left, key);

            }

            return node;
        }

        public bool Contains(int key)
        {
            BSTNode node = _root;

            while (true)
            {
                if (node.Key == key)
                    return true;

                if (key > node.Key)
                {
                    if (node.Right == null)
                        return false;
                    else
                        node = node.Right;
                }
                else if (key < node.Key)
                {
                    if (node.Left == null)
                        return false;
                    else
                        node = node.Left;
                }
            }
            //return false;
        }

        public void Remove(int key)
        {
            _root = RemoveRec(_root, key);
        }

        private BSTNode RemoveRec(BSTNode node, int key)
        {
            // 삭제하려는 노드가 널일때
            //if(Contains(key) == false)
            //    return node;

            if (node == null)
                return null;

            // 삭제하려는 키가 현재 노드보다 작다면
            else if(key < node.Key)
                node.Left = RemoveRec(node.Left, key);

            // 삭제하려는 키가 현재 노드보다 크다면
            else if(key > node.Key)
                node.Right = RemoveRec(node.Right, key);
            else
            {
                // 모두가 아니라면 == 즉 현재 노드가 삭제하려는 노드라면
                if (key == node.Key)
                {
                    // 자식 없는 노드라면
                    if (node.Left == null && node.Right == null)
                    {
                        return null;
                    }

                    // 자식이 1개 있는 노드라면
                    if (node.Left == null)
                        return node.Right;
                    else if (node.Right == null)
                        return node.Left;

                    BSTNode min = FindMin(node.Right);
                    node.Key = min.Key;
                    node.Right = RemoveRec(node.Right, min.Key);
                }
            }
            
            return node;
        }

        private BSTNode FindMin(BSTNode node)
        {
            while (node.Left != null)
                node = node.Left;

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
            b.Insert(-3);
            b.Insert(-2);
            b.Insert(5);
            b.Insert(4);
            b.Insert(6);

            Console.WriteLine(b.Contains(0) + " 0");
            Console.WriteLine(b.Contains(1) + " 1");
            Console.WriteLine(b.Contains(2) + " 2");
            Console.WriteLine(b.Contains(9) + " 9");
            Console.WriteLine(b.Contains(-1) + " -1");
            Console.WriteLine(b.Contains(8) + " 8");
            Console.WriteLine(b.Contains(-3) + " -3");
            Console.WriteLine(b.Contains(5) + " 5");
            Console.WriteLine(b.Contains(3) + " 3");
            Console.WriteLine(b.Contains(4) + " 4");
            Console.WriteLine(b.Contains(6) + " 6");

            b.Remove(3);
        }
    }
}
