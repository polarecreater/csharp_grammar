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
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);

            list.AddFirst(0);

            Node<int> find = list.Find(3);//값 기준 찾기
            Console.WriteLine(find.Data);//탐색한 노드의 값 출력

            //list.AddAfter(find,10);
            
            list.Remove(find);
            Console.WriteLine(list.ToString());//전체 데이터 출력
        }
        
    }
}