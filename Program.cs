using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: 복습
 * DESC: 자료구조 DoubleLinkedList
 * 
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        //강의 코드
        
        static void Main(string[] args)
        {
            LinkedList<int> _dll = new LinkedList<int>();
            _dll.AddFirst(8);
            //LinkedListNode<int> _n = new LinkedListNode<int>(3);//이렇게 만든건 does not belong to current linkedlist 라고 에러난다.
            _dll.AddLast(10);
            _dll.AddLast(3);
            LinkedListNode<int> temp = _dll.Find(10);
            _dll.AddBefore(temp, 6);
            Console.WriteLine(string.Join(",", _dll));
            _dll.Remove(temp);
            Console.WriteLine(string.Join(",", _dll));

        }
        
    }
}