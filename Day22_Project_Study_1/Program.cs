using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day22_Project_Study_1
{ 
    //원래 링크드 리스트에선 노드가
    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> Neighbors { get; private set; }
    
        public Node(T value) 
        {
            Value = value;
            Neighbors = new List<Node<T>>();
        }
    }

    public class SimipleGraph<T>
    {
        //▼ 노드들을 관리하는 리스트 뉴할당
        List<Node<T>> _nodes = new List<Node<T>>();

        //▼ 노드 새로 추가하는 기능
        public Node<T> AddNode(T value)
        {
            //여기서 일어난 뉴할당은 진짜 새로운 노드 생성
            Node<T> node = new Node<T>(value);

            _nodes.Add(node);

            return node;
        }

        //▼ 단방향 간선 추가
        public void AddEdge(Node<T> from, Node<T> to)
        {
            //출발점의 노드가 가진 리스트에, 목적지 노드 추가
            from.Neighbors.Add(to);
        }

        //▼ 양방향 간선 추가
        public void AddUndirectedEdge(Node<T> from, Node<T> to)
        {
            from.Neighbors.Add(to);
            to.Neighbors.Add(from);
        }

        public void PrintGraph()
        {
            foreach (Node<T> node in _nodes)
            {
                Console.Write($"{node.Value} -> ");

                foreach(var neighbor in node.Neighbors)
                {
                    Console.Write($"{neighbor.Value} ");
                }
                Console.WriteLine();
            }
        }

        
        //BFS 너비, DFS 깊이
        //큐를 사용해 탐색할거임
        //시작 노드를 큐에 담고 탐색을 시작함
        public void BFS(Node<T> start, Node<T> target)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            List<Node<T>> visited = new List<Node<T>>();    //방문 기록용

            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                Node<T> current = queue.Dequeue();

                if (visited.Contains(current))
                {
                    continue;
                }

                Console.WriteLine($"{current.Value}");
                visited.Add(current);

                if (current.Equals(target))
                {
                    Console.WriteLine($"목적지 {target.Value} 도달");
                    return;
                }

                foreach (var neighbor in current.Neighbors)
                {
                    if (!visited.Contains(neighbor))
                    { 
                        queue.Enqueue(neighbor);
                    }
                }
            }
            Console.WriteLine("경로 탐색 실패");
        }

        public void DFS(Node<T> start, Node<T> target)
        {
            Stack<Node<T>> stack = new Stack<Node<T>>();
            List<Node<T>> visited = new List<Node<T>>();    //방문 기록용

            stack.Push(start);

            while (stack.Count > 0)
            {
                Node<T> current = stack.Pop();

                if (visited.Contains(current))
                {
                    continue;
                }

                Console.WriteLine($"{current.Value}");
                visited.Add(current);

                if (current.Equals(target))
                {
                    Console.WriteLine($"목적지 {target.Value} 도달");
                    return;
                }

                foreach (var neighbor in current.Neighbors)
                {
                    if (!visited.Contains(neighbor))
                    {
                        stack.Push(neighbor);
                    }
                }
            }
            Console.WriteLine("경로 탐색 실패");
        }








    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //원소들이 순차적으로 혹은 선형으로 앞뒤로 연결된 구조가
            //선형구조 (Linear Data Structure)

            //LinkedList - 바로 다음 자료 알 수 있는지? .Next로 
            //배열 (혹은 List) [0], [1] ...
            //스택
            //큐

            SimipleGraph<string> graph = new SimipleGraph<string>();

            var nodeA = graph.AddNode("A");
            var nodeB = graph.AddNode("B");
            var nodeC = graph.AddNode("C");
            var nodeD = graph.AddNode("D");
            var nodeE = graph.AddNode("E");

            //간선 추가
            graph.AddEdge(nodeA, nodeB);
            graph.AddEdge(nodeA, nodeC);
            graph.AddEdge(nodeB, nodeD);
            graph.AddEdge(nodeC, nodeE);

            //출력
            graph.PrintGraph();

        }
    }
}
