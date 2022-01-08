using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*-----------------------------------------------------------------------------
 * Name: 재귀 호출 
 * DESC: 재귀 호출 강의 코드
 * 
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        static void Main(string[] args)
        {
            int nValue = 10;
            Console.WriteLine("Factorial "+ nValue + "-" + FuncFactorial(nValue));
        }
        static int FuncFactorial(int nNumber){
            int nResult = 0;
            if(nNumber == 1){
                nResult = 1;
            }
            else{
                nResult = nNumber * FuncFactorial(nNumber -1);
            }
            return nResult;
        }
    }
}
