namespace _1_이진검색트리_binary_search_tree_BST_
{
    //이진 검색 트리
    // 왼쪽 값은 나보다  작은값
    // 오른쪽 값은 나보다 큰값
    // 잘 정리 되있다는 기준으로 값을 빠르게 찾기 가능
    //  ㄴ O(log n) (평균 : 트리가 균형잡혀 있을 때)
    // 정돈된 값을 넣을 경우 트리의 균형이 깨질수 있다
    // 균형이 깨진 이진 검색 트리는 탐색 속도가 느려진다.
    //  ㄴ O(n) (최악 : 트리가 한쪽으로 치우쳐서 사실상 연결 리스트가 되었을 때)

    //균형이 깨지는걸 대비하기 위해 스스로 복구하는 균형 트리라는게 있다
    //추가적을 삽입시 스스로 균형을 유지하게끔 만들어진 트리
    // AVL, RedBlack, treee, B tree

    class BstNode
    {
        public int Key;
        public BstNode Left;
        public BstNode Right;

        public BstNode(int key) { this.Key = key; }
    
    }

    class BinarySearchTree
    {
        private BstNode _root;

        //삽입
        public void Insert(int key)
        {
            _root = InsertRec(_root, key);
        }

        private BstNode InsertRec(BstNode node, int key)
        {
            //노드가 하나도 없을 경우
            if (node == null)
                return new BstNode(key);

            if(key < node.Key)
                node.Left = InsertRec(node.Left, key);

            if(key > node.Key)
                node.Right = InsertRec(node.Right, key);

            return node;
        }

        //탐색
        public bool Contains(int key)
        {
            var now = _root;
            while (now != null)
            {
                if (key == now.Key)
                    return true;

                now = (key < now.Key) ? now.Left : now.Right;
            }
            return false;
        }

        //삭제
        public void Remove(int key)
        {
            _root = RemoveRec(_root, key);
        }

        private BstNode RemoveRec(BstNode node, int key)
        {
            if (node == null)
                return null;

            if(key < node.Key)
            {
                node.Left = RemoveRec(node.Left, key);
            }
            else if(key > node.Key)
            {
                node.Right = RemoveRec(node.Right, key);
            }
            else
            {
                //case 1 : 리프
                if (node.Left == null && node.Right == null)
                    return null;

                //case 2 : 자식 1개
                if(node.Left == null)
                    return node.Right;
                if (node.Right == null)
                    return node.Left;

                //case 3 : 자식 2개
                BstNode min = FindMin(node.Right);
                node.Key = min.Key;
                node.Right = RemoveRec(node.Right, min.Key);
            }

            return node;
        }

        private BstNode FindMin(BstNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var bst = new BinarySearchTree();
            int[] data = { 16, 14, 78, 31, 90, 5, 15, 1, 10, 87 };

            foreach (var x in data)
            {
                bst.Insert(x);
            }

            bst.Remove(16);
        }
    }
}
