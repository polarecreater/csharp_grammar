using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: SingleLinkedList
 * DESC: 자료구조 SingleLinkedList
 * Node.cs, SingleLinkedList.cs 사용
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        //강의 코드
        static void Main(string[] args)
        {
           LinkedList<int> number = new LinkedList<int>();
           number.AddFirst(10);
           number.AddLast(20);
           number.AddFirst(0);
           number.AddLast(30);

           //노드 찾기
           LinkedListNode<int> nodeTemp = number.Find(20);

           number.AddAfter(nodeTemp,25);
           number.AddBefore(nodeTemp,15);

           number.Remove(10);//값으로 삭제

           //검색 후 출력
           for (var node = number.First ; node != null ; node = node.Next)
           {
               Console.WriteLine(node.Value);
           }
           
        }
        
    }
}