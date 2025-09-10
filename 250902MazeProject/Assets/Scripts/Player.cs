
using System;
using System.Collections.Generic;
using UnityEngine;

class Pos
{
    public Pos(int y, int x) { Y = y; X = x; }

    public int Y;
    public int X;
}

public class Player : MonoBehaviour
{
    public int PosY { get; set; }
    public int PosX { get; set; }

    private Board _board;
    private bool _isBoardCreated = false;

    enum Dir
    {
        Up = 0,
        Left = 1,
        Down = 2,
        Right = 3,
    }

    int _dir = (int)Dir.Up; // 0

    List<Pos> _points = new List<Pos>();
    
    public void Initialze(int posY, int posX, Board board)
    {
        PosY = posY;
        PosX = posX;
        _board = board;

        transform.position = new Vector3(posX, 0, -posY);

        _points.Clear();
        _lastIndex = 0;

        //RightHand();
        //BFS();
        Astar();

        _isBoardCreated = true;

    }

    // ����� - (�̷θ� Ż���ϱ� ����) ������ ��Ģ
    void RightHand()
    {
        // ���� �ٶ󺸴� ���� ���� �չ��� Ÿ���� Ȯ�� �ϱ� ���� ��ǥ
        int[] _frontY = new int[] { -1, 0, 1, 0 }; // up, left, down, right {enum Dir}
        int[] _frontX = new int[] { 0, -1, 0, 1 }; // up, left, down, right {enum Dir}

        // ���� �ٶ󺸴� ���� ���� ������ Ÿ���� Ȯ�� �ϱ����� ��ǥ
        int[] _rightY = new int[] { 0, -1, 0, 1 }; // up, left, down, right {enum Dir}
        int[] _rightX = new int[] { 1, 0, -1, 0 }; // up, left, down, right {enum Dir}

        _points.Add(new Pos(PosY, PosX));

        // ������ ����� ���� ��ӽ���
        while (PosY != _board.DestY || PosX != _board.DestX)
        {
            // 1. ���� �ٶ󺸴� ������ �������� ���������� �� �� �ִ��� Ȯ��

            // ���� ���� �ٶ� ���� �ִ� �������, ������ �� Ÿ���� Ȯ���ؾ��ϴϱ�
            if (_board.Tile[PosY + _rightY[_dir], PosX + _rightX[_dir]] != TileType.Wall)
            {
                #region 
                // ������ �������� 90�� ȸ��
                // ��ⷯ ����(modular arithmetic)�� �̿��� ���� �ε���(circular index) ����
                // ��ⷯ ���� = ������ ���� %�� ����ؼ� ���� ������ �����ϴ� ������ ���.
                // ���� �ε��� = ������ ������ ��� �ε����� ������ �ʵ��� ���� �����ϸ� �ٽ� ó������ ���ư��� ����
                #endregion

                _dir = (_dir - 1 + 4) % 4;
                #region
                //   [ ]
                //[ ] P [*] 
                //   [^]

                //switch (_dir)
                //{
                //    case (int)Dir.Up:
                //        _dir = (int)Dir.Right;
                //        break;
                //    case (int)Dir.Left:
                //        _dir = (int)Dir.Up;
                //        break;
                //    case (int)Dir.Down:
                //        _dir = (int)Dir.Left;
                //        break;
                //    case (int)Dir.Right:
                //        _dir = (int)Dir.Down;
                //        break;
                //}


                // X: 1, Y: 1
                // ���� �ٶ󺸴� �������� ������ �Ѻ� ����
                //   [ ]
                //[ ] P [*] 
                //   [ ]


                #endregion

                PosY = PosY + _frontY[_dir];
                PosX = PosX + _frontX[_dir];

                _points.Add(new Pos(PosY, PosX));
            }
            // 2. ���� �ٶ󺸴� ������ �������� ������ �� �ִ��� Ȯ��
            else if (_board.Tile[PosY + _frontY[_dir], PosX + _frontX[_dir]] != TileType.Wall)
            {
                // ������ �Ѻ� ����
                PosY = PosY + _frontY[_dir];
                PosX = PosX + _frontX[_dir];

                _points.Add(new Pos(PosY, PosX));
            }
            // 3. �� ������, �� �� ��� ���� �ִٸ�
            else
            {
                // ���� �������� 90�� ȸ�� �� �� �ѱ��
                _dir = (_dir + 1 + 4) % 4;
            }
        }
    }

    void BFS()
    {
        int[] deltaY = new int[] { -1, 0, 1, 0 };
        int[] deltaX = new int[] { 0, -1, 0, 1 };

        bool[,] found = new bool[_board.Size, _board.Size];
        Pos[,] parant = new Pos[_board.Size, _board.Size];

        //Stack<Pos> _points = new Stack<Pos>();

        Queue<Pos> queue = new Queue<Pos>();
        queue.Enqueue(new Pos(PosY, PosX));
        found[PosY, PosX] = true;
        parant[PosY, PosX] = new Pos(PosY, PosX);

        while (queue.Count > 0) 
        {
            Pos pos = queue.Dequeue();
            int nowY = pos.Y;
            int nowX = pos.X;

            for (int i = 0; i < 4; i++)
            {
                int nextY = nowY + deltaY[i];
                int nextX = nowX + deltaX[i];

                //������ �ʰ��ϴ���
                if (nextY < 0 || nextY >= _board.Size || nextX < 0 || nextX >= _board.Size)
                    continue;

                //üũ�Ϸ��� ���� ���� �ִ� ������
                if (_board.Tile[nextY, nextX] == TileType.Wall)
                    continue;

                //�̹� ã�� ������ Ȯ��
                if (found[nextY, nextX] == true)
                    continue;

                queue.Enqueue(new Pos(nextY, nextX));
                found[nextY, nextX] = true;
                parant[nextY, nextX] = new Pos(nowY, nowX);
            }
        }

        CalcPathFromParent(parant);

        //int y = _board.DestY;
        //int x = _board.DestX; 

        //while (parant[y, x].Y != y || parant[y, x].X != x)
        //{
        //    //_points.Push(new Pos(y, x));

        //    //[0] => ������
        //    //[1] => ������ �θ�
        //    // ...
        //    //[�������ε���] => ���� ����

        //    _points.Add(new Pos(y, x));
        //    Pos pos = parant[y, x];
        //    y = pos.Y;
        //    x = pos.X;
        //}

        //_points.Add(new Pos(y, x)); // �������� �����߰�
        //_points.Reverse();
        ////[0] => ���� ����
        ////[1] => ���� ���� ����
        //// ...
        ////[�������ε���] => ������
    }

    void CalcPathFromParent(Pos[,] parent)
    {
        int y = _board.DestY;
        int x = _board.DestX;

        while (parent[y, x].Y != y || parent[y, x].X != x)
        {
            // [0] => ������
            // [1] => ������ �θ�
            // ...
            // [�������ε���] => ���� ����
            _points.Add(new Pos(y, x));

            Pos pos = parent[y, x];
            y = pos.Y;
            x = pos.X;
        }

        _points.Add(new Pos(y, x)); // �������� ���� �߰�
        // [0] => ���� ����
        // [1] => ���� ���� ����
        // ...
        // [�������ε���] => ������
        _points.Reverse();
    }

    //��Ʈ��Ʈ�� ���� ����
    // 1. �������̶� ���Ҵ� / GC �δ��� ����
    // class�� ���������̶� new �Ҷ����� ��(heap)�� ��ü�� �����, GC�� �����ؾ���
    // struct�� �������̶� �����̳� �迭 ���ο� �ٷ� �����
    // ��, �켱���� ť���� ��û���� ��带 Push/Pop �Ҷ� GC Alloc�� �ٰ� ������ �������� ����

    //2. ũ�Ⱑ ���� ������ �����̱� ������ struct�� ����
    // PQNode�� ��� �մ� �ʵ尡 � �ȵǰ� struct�� �� �׷� �������� ���� ��������� ����
    // .net�� ������ ���̵忡�� ����ü�� 16����Ʈ �̳���� Ŭ����(��ü)���� ���ɻ� �����ϴ� ��������

    struct PQNode : IComparable<PQNode>
    {
        public int F;
        public int G;
        public int Y;
        public int X;

        public int CompareTo(PQNode other)
        {
            if (F == other.F)
            {
                return 0;
            }

            return F < other.F ? 1 : -1;
        }
    }

    


    void Astar()
    {
        //up left down right + UL DL DR UR
        int[] dY = new int[] { -1, 0, 1, 0, -1, 1, 1, -1 };
        int[] dX = new int[] { 0, -1, 0, 1, -1, -1, 1, 1 };

        int[] cost = new int[] { 10, 10, 10, 10, 14, 14, 14, 14 }; // G

        //���� �ű��
        // F = G + H
        // F = ���� ���� (�ۿ� ���� ����, ��ο� ���� �޶���)
        // G = ���������� �ش� ��ǥ���� �̵��ϴµ� ��� ���(�������� ����, ��ο� ���� �޶���)
        // H = ���������� �󸶳� ������� (�������� ����, ����) (ĭ���� ���� ����)

        //(y, x) �̹� �湮�ߴ��� ���� (�湮  = closed ����)
        bool[,] closed = new bool[_board.Size, _board.Size]; //CloseList 
        //(y, x) ���� ���� �ѹ��̶� �߰��ߴ���
        // �߰� X -> MaxValue
        int[,] open = new int[_board.Size, _board.Size]; // OpenList

        for (int y = 0; y < _board.Size; y++)
        {
            for (int x = 0; x < _board.Size; x++)
            {
                open[y, x] = Int32.MaxValue;
            }
        }

        Pos[,] parent = new Pos[_board.Size, _board.Size];

        //���¸���Ʈ�� �ִ� ������ �߿���, ���� ���� �ĺ��� ������ �̾ƿ��� ���� �켱���� ť
        PriorityQueue<PQNode> pq = new PriorityQueue<PQNode>();


        //������ �߰�(��������)
        open[PosY, PosX] = /* G = 0 */ /* H = -> */10 * (Math.Abs(_board.DestY - PosY) + Math.Abs(_board.DestX - PosX));

        pq.Push(new PQNode()
        {
            F = 10 * (Math.Abs(_board.DestY - PosY) + Math.Abs(_board.DestX - PosX)),
            G = 0,
            Y = PosY,
            X = PosX
        });

        parent[PosY, PosX] = new Pos(PosY, PosX);

        while (pq.Count /*Count()*/ > 0)
        {
            //���� ���� �ĺ� ã��
            PQNode Node = pq.Pop();

            //������ ��ǥ�� ������η� ã�Ƽ� , �� ���� ��η� ���ؼ� �̹� �湮(cloesd)�� ��� ��ŵ

            // �츮�� ���� PriorityQueue�� DecreaseKey�� ���� �ܼ� Push/Pop ��
            // ���� ť�� ���� Ű�� �������� ����Ű�� ����� �� ����Ű�� ������ ����� ����
            // �ߺ��Ǵ� Ű�� ������� �ְ� �װ� �����ϱ� ���� �ڵ�
            if (closed[Node.Y, Node.X])
                continue;

            //�湮 �ϱ�
            closed[Node.Y, Node.X] = true;

            //�������� �����ϸ� �ٷ� ����
            if (Node.Y == _board.DestY && Node.X == _board.DestX)
                break;

            //�����¿� �� �̵��Ҽ� �մ� ��ǥ���� Ȯ���ؼ� ����(open) �Ѵ�
            for (int i= 0; i < 8 /*dY.Length*/; i++)
            {
                int nextY = Node.Y + dY[i];
                int nextX = Node.X + dX[i];

                //��ȿ���� ����� ��ŵ
                if (nextY < 0 || nextY > _board.Size || nextX < 0 || nextX > _board.Size)
                    continue;

                //������ ���������� ��ŵ(�������� ��ŵ)
                if (_board.Tile[nextY, nextX] == TileType.Wall)
                    continue;

                //�̹� �湮 ������ ��ŵ
                if (closed[nextY, nextX] == true)
                    continue;

                //��� ���
                int g = Node.G + cost[i];
                int h = 10 * (Math.Abs(_board.DestY - nextY) + Math.Abs(_board.DestX - nextX));

                //�ٸ� ��ο��� �� �������� �̹� ã������ ��ŵ
                if (open[nextY, nextX] < g + h)
                    continue;

                //���� ����
                open[nextY, nextX] = g + h;

                //ť�� ����
                pq.Push(new PQNode() { F = g + h, G = g, Y = nextY, X = nextX });
                parent[nextY, nextX] = new Pos(Node.Y, Node.X);
            }
        }

        CalcPathFromParent(parent);
    }

    private const float MOVE_TICK = 0.1f;
    private float _sumTick = 0;
    private int _lastIndex = 0;

    private void Update()
    {
        if (_lastIndex >= _points.Count)
            return;

        if (_isBoardCreated == false)
            return;

        _sumTick += Time.deltaTime;
        if (_sumTick < MOVE_TICK)
            return;

        _sumTick = 0;

        //int dir = Random.Range(0, 4);

        //int NextY = PosY;
        //int NextX = PosX;

        //switch (dir)
        //{
        //    case 0:
        //        NextY = PosY - 1;
        //        break;
        //    case 1:
        //        NextY = PosY + 1;
        //        break;
        //    case 2:
        //        NextX = PosX - 1;
        //        break;
        //    case 3:
        //        NextX = PosX + 1;
        //        break;
        //}

        //if (NextY < 0 || NextY >= _board.Size) return;
        //if (NextX < 0 || NextX >= _board.Size) return;
        //if (_board.Tile[NextY, NextX] == TileType.Wall) return; 

        //PosY = NextY;
        //PosX = NextX;

        PosY = _points[_lastIndex].Y;
        PosX = _points[_lastIndex].X;
        _lastIndex++;

        transform.position = new Vector3(PosX, 0, -PosY);
    }

}
