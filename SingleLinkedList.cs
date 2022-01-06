namespace csharp_grammar
{
    public class SingleLinkedList<T>
    {
        private Node<T> m_head;//맨처음 노드
        public void AddLast(T data){
            Node<T> node = new Node<T>(data);

            if(m_head == null){//아무것도 없을 때 - 첫번째 노드를 들어오는 노드에 연결
                m_head = node;
            }
            else{
                Node<T> last = m_head;

                while(last.Next != null){//마지막 노드 찾기
                    last = last.Next;
                }
                last.Next = node;
            }
        }

        public void AddFirst(T value){
            Node<T> node = new Node<T>(value);
            node.Next = m_head;//head에 있던 걸 뒤로 미룸
            m_head = node;//head에 node를 넣음
        }

        public Node<T> Find(T value){
            if(m_head != null){
                Node<T> value_Node = new Node<T>(value);//값 넣는 노드랑 비교
                Node<T> node = m_head;//탐색 노드

                while(node != null){
                    if(node.Data.Equals(value_Node.Data)){
                        break;
                    }
                    node = node.Next;
                }
                return node;
            }else{
                return null;
            }
            
        }
        public void AddAfter(Node<T> findNode, T value){
            Node<T> node = new Node<T>(value);

            node.Next = findNode.Next;//찾은 노드의 다음 노드 주소를 새로 만든 노드와 연결
            findNode.Next = node;//새로 만든 노드를 찾은 노드의 다음으로 연결

        }

        public void Remove(Node<T> removeNode){
            
            Node<T> node = m_head;//순환하면서 삭제할 노드 찾음
            Node<T> nodeBefore = null;
            while(node != removeNode){
                nodeBefore = node;
                node = node.Next;
            }
            if(nodeBefore ==null){//첫번쨰 노드를 삭제하게 되었을 때 before는 null
                m_head = removeNode.Next;//두번째 노드가 헤드에 들어감
            }else{
                nodeBefore.Next= removeNode.Next;//전 노드에 삭제할 노드의 다음 주소를 연결
                node = null;//삭제
            } 
        }
        override
        public string ToString(){//전체 데이터 출력
             var temp = m_head;
             string data = "";
             while(temp != null){
                 if(!string.IsNullOrEmpty(data))
                     data += ",";
                 data += temp.Data.ToString();
                 temp = temp.Next;
             }
             return data;

        }
    }
}