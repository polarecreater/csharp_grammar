using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: Stack
 * DESC: 자료구조 Stack
 * 
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        //강의 코드
        static void Main(string[] args)
        {
            //제네릭 타입이 아니어서 다양한 타입의 데이터 넣을 수 있음
           Stack stack1 = new Stack();
           stack1.Push("a");
           stack1.Push(1);
           stack1.Push(true);

           while(stack1.Count > 0){
               Console.WriteLine(stack1.Pop());
           } 
           stack1.Push("ArrayStack");
            //효율 좋지 않아서 명시적 타입 지정 필요

            //명시적 타입 지정한 스택
            Stack<int> stack2 = new Stack<int>();
            stack2.Push(1);
            stack2.Push(2);
            stack2.Pop();
            stack2.Push(3);
            stack2.Push(4);
            stack2.Peek();
            stack2.Push(5);

            Console.WriteLine("stack2 갯수 "+stack2.Count);
            while(stack2.Count>0){
                Console.Write(stack2.Pop());
            }
        }
        
    }
}