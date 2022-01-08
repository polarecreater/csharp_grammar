using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*-----------------------------------------------------------------------------
 * Name: ArrayStack 구현
 * DESC: 자료구조 스택 배열로 구현
 * 
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack arrayStack = new ArrayStack(5);

            arrayStack.Push(1);
            arrayStack.Push(2);
            arrayStack.Push(3);
            arrayStack.Push(4);
            arrayStack.Push(5);

            while(arrayStack.Count>0){
                Console.WriteLine(arrayStack.Pop());
            }
        }
    }
}
