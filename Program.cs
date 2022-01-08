using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*-----------------------------------------------------------------------------
 * Name: 재귀 호출 피보나치
 * DESC: 재귀 호출 피보나치 강의 코드
 * 
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        static void Main(string[] args)
        {
            int nValue = 10;
            Console.WriteLine("Fibonacci " + nValue + " - " + FuncFibonacci(nValue));
        }
        static int FuncFibonacci(int nSequence){
            int nResult = 0;
            if(nSequence == 1 || nSequence == 2){
                nResult = 1;
            }else{
                nResult = FuncFibonacci(nSequence - 1) + FuncFibonacci(nSequence - 2);
            }
            return nResult;
        }
    }
}
