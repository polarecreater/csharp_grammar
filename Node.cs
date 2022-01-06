namespace csharp_grammar
{
    public class Node<T>
    {
        public T Data {get; set;}//제네릭 타입
        public Node<T> Next{get; set;}

        public Node(T data){//링크드 리스트 노드
            Data = data;
            Next = null;//아직 다음 값 몰라서 null
        }
    }
}