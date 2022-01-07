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
        
        static void Main(string[] args)
        {
            Stack<int> _si = new Stack<int>();
            _si.Push(22);
            _si.Push(11);
            _si.Push(33);
            Console.WriteLine(_si.Peek());
            _si.Pop();
            Console.WriteLine(_si.Peek());
            _si.Pop();
            Console.WriteLine(_si.Peek());
            _si.Push(99);
            Console.WriteLine(string.Join(",", _si));
            //결과값
            // 33
            // 11
            // 22
            // 99,22
            
        }
        
    }
}