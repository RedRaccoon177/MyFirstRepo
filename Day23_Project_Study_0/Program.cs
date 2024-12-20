using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_Project_Study_0
{
    public class Edge<T>
    {
        public Node<T> To { get; set; }

        //▼ 가중치(weight)노드에서 노드 가는데 걸리는 시간
        public int Weight { get; set; }

        public Edge(Node<T> to, int weight)
        {
            To = to;
            Weight = weight;
        }
    }

    // 노드 클래스
    public class Node<T>
    {
        public T Value { get; set; } // 노드의 데이터
        public List<Edge<T>> Neighbors { get; private set; } = new List<Edge<T>>(); // 이웃 노드 리스트

        public Node(T value)
        {
            Value = value;
        }

    }

    // 그래프 클래스
    public class SimpleGraph<T>
    {
        private List<Node<T>> _nodes = new List<Node<T>>(); // 그래프의 모든 노드 저장

        // 노드 추가 메서드
        public Node<T> AddNode(T value)
        {
            var node = new Node<T>(value);
            _nodes.Add(node);
            return node;
        }

        // 단방향 간선 추가
        public void AddEdge(Node<T> from, Node<T> to, int weight)
        {
            from.Neighbors.Add(new Edge<T> (to, weight));
        }

        // 양방향 동일하다는 가정 하의 간선 간선 추가
        public void AddUndirectedEdge(Node<T> a, Node<T> b, int weight)
        {
            a.Neighbors.Add(new Edge<T>(b, weight));
            b.Neighbors.Add(new Edge<T>(a, weight));
        }

        // 그래프 출력
        public void PrintGraph()
        {
            foreach (var node in _nodes)
            {
                Console.Write($"{node.Value} -> ");
                foreach (var neighbor in node.Neighbors)
                {
                    Console.Write($"{neighbor.To.Value}, 걸리는 시간: {neighbor.Weight} ");
                }
                Console.WriteLine();
            }
        }

        // BFS 탐색
        public void Bfs(Node<T> start, Node<T> target)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            List<Node<T>> visited = new List<Node<T>>(); // 방문 기록을 List로 관리

            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                Node<T> current = queue.Dequeue();
                if (visited.Contains(current)) // 중복 방문 방지
                    continue;

                Console.WriteLine($"노드 방문: {current.Value}");
                visited.Add(current); // 방문한 노드 기록

                if (current.Equals(target)) // 목표 노드 발견
                {
                    Console.WriteLine($"목표 노드 {target.Value} 발견!");
                    return;
                }

                foreach (Edge<T> neighbor in current.Neighbors)
                {
                    if (!visited.Contains(neighbor.To)) // 이미 방문한 노드는 제외
                    queue.Enqueue(neighbor.To);
                }
            }

            Console.WriteLine("경로를 찾을 수 없습니다.");
        }

        // DFS 탐색
        public void Dfs(Node<T> start, Node<T> target)
        {
            Stack<Node<T>> stack = new Stack<Node<T>>();
            List<Node<T>> visited = new List<Node<T>>(); // 방문 기록을 List로 관리

            stack.Push(start);

            while (stack.Count > 0)
            {
                Node<T> current = stack.Pop();
                if (visited.Contains(current)) // 중복 방문 방지
                    continue;

                Console.WriteLine($"노드 방문: {current.Value}");
                visited.Add(current); // 방문한 노드 기록

                if (current.Equals(target)) // 목표 노드 발견
                {
                    Console.WriteLine($"목표 노드 {target.Value} 발견!");
                    return;
                }

                foreach (var neighbor in current.Neighbors)
                {
                    if (!visited.Contains(neighbor.To)) // 이미 방문한 노드는 제외
                        stack.Push(neighbor.To);
                }
            }

            Console.WriteLine("경로를 찾을 수 없습니다.");
        }
    }

    // 테스트 코드
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGraph<string> graph = new SimpleGraph<string>();

            // 노드 추가
            var nodeA = graph.AddNode("A");
            var nodeB = graph.AddNode("B");
            var nodeC = graph.AddNode("C");
            var nodeD = graph.AddNode("D");
            var nodeE = graph.AddNode("E");

            // 간선 추가
            graph.AddEdge(nodeA, nodeB, 1);
            graph.AddEdge(nodeB, nodeC, 7);
            graph.AddEdge(nodeC, nodeD, 3);
            graph.AddEdge(nodeD, nodeE, 5);

            // 그래프 출력
            Console.WriteLine("그래프 구조:");
            graph.PrintGraph();

            // BFS 탐색
            Console.WriteLine("\nBFS 탐색:");
            graph.Bfs(nodeA, nodeE);

            // DFS 탐색
            Console.WriteLine("\nDFS 탐색:");
            graph.Dfs(nodeA, nodeE);
        }
    }

}
