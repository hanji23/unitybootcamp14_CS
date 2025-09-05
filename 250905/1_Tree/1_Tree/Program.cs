using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace _1_Tree
{
    //트리 - (계층적인 구조를 갖는 데이터)를 표현하기 위한 자료 구조
    // 트리는 무조건 단방향으로 뻗음
    // 부모에 해당하는 아이는 딱하나만 있어야함
    // 트리는 재귀적인 속성을 갖고 있다
    // 트리의 연산은 재귀함수가 애용됨

    // 트리는 제공되는 자료구조가 없음 -> 직접 구현

    // 그래프는 정적인 상황에서 사용(데이터가 잘 바뀌지 않는 상황)
    // 트리는 데이터의 변화가 자주 일어날때 사용한다
    // ㄴ 트리는 현실세계에서 동적으로 변하는 데이터를 다루기 위한 자료구조

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

        // 트리 순회
        static void Print(TreeNode<string> root)
        {
            // 모든 노드의 데이터를 출력하는 함수를 만들기 (순서 상관 없음)
            Console.WriteLine($" {root.Data} 입니다");

            for (int i = 0; i < root.Children.Count; i++)
            {
                Console.WriteLine($" {root.Data}의 {i + 1}번 자식인 {root.Children[i].Data} 입니다");
                if (root.Children[i].Children.Count > 0)
                {
                    Print(root.Children[i]);
                }
            }

            foreach (var child in root.Children)
            {
                Print(child);
            }
        }

        static int GetHight(TreeNode<string> root) // 코딩테스트문제로 많이 나옴
        {
            int height = 0;

            foreach(var child in root.Children)
            {
                int newHeight = GetHight(child) + 1;
                //if(height < newHeight)
                //    height = newHeight;
                // 아래와 같음

                height = Math.Max(height, newHeight);
            }
            
            return height;
        }

        static void Main(string[] args)
        {

            TreeNode<string> root = MakeTree();

            Print(root);
            Console.WriteLine($"\n{GetHight(root)}");
        }
    }
}
