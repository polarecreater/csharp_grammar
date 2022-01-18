using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*-----------------------------------------------------------------------------
 * Name: 그래프
 * DESC: 그래프 강의 코드
 * 인접 리스트로 표현
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        static void Main(string[] args){
            Graph<string> gr = new Graph<string>();
            
            //간선 잇기 전에 정점 필요
            var v1 = gr.AddVertex("서울");
            var v2 = gr.AddVertex("프랑스");
            var v3 = gr.AddVertex("미국");
            var v4 = gr.AddVertex("방콕");

            //간선 이음
            gr.AddEdge(v1,v2,6);//숫자는 가중치
            gr.AddEdge(v1,v3,1);
            gr.AddEdge(v1,v4,2);
            gr.AddEdge(v2,v3,4);
            gr.AddEdge(v3,v4,9);

            gr.ToString();

        }
        public class GraphNode<T>{
            public T Data{get; set;}
            public List<GraphNode<T>> AdjcencyNode{get; private set;}
            public List<int> Weight{get; private set;}//가중치
            public GraphNode(){//생성자
                AdjcencyNode = new List<GraphNode<T>>();//생성자에서 초기화해야 함
                Weight = new List<int>();
            }

            public GraphNode(T data): this(){
                Data = data;
            }
        }

        public class Graph<T>
        {
            private List<GraphNode<T>> nodes;//노드 저장할 리스트

            private bool directedGraph;//방향성 그래프 표현
            public Graph(bool directedGraph = false){//생성자 - 인자 설정하지 않으면 디폴트로 false
                this.nodes = new List<GraphNode<T>>();//클래스 내부 변수에 인자 값 넣음
                this.directedGraph = directedGraph;
            }
            public GraphNode<T> AddVertex(T data){//정점 추가
                return AddVertex(new GraphNode<T>(data));//반환값
            }
            public GraphNode<T> AddVertex(GraphNode<T> node){
                nodes.Add(node);
                return node;
            }
            public void AddEdge(GraphNode<T> from, GraphNode<T> to, int weight = 1){//간선 추가
                from.AdjcencyNode.Add(to);//인접한 노드에 연결
                from.Weight.Add(weight);//가중치 추가
                if(!directedGraph)//방향성 그래프 아니면
                {
                    to.AdjcencyNode.Add(from);//양쪽 똑같이 바라봄
                    to.Weight.Add(weight);//양쪽 똑같이 가중치
                }            
            }
            override
            public string ToString(){//출력
                foreach(var item in nodes){
                    for(int i = 0 ; i< item.AdjcencyNode.Count; i++){//이어진 노드 순회
                        Console.WriteLine(item.Data + "--" + item.Weight[i] + "--" + item.AdjcencyNode[i].Data);//노드들간 연결과 가중치 표시
                    }
                }
                return "";
            }
        }
    }
}
