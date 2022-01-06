using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: List<T> 
 * DESC: 자료구조 List<T>
 * 예시 코드
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        //강의 코드
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(4);
            list.Add(7);
            list.Add(5);
                
            list.Sort();//정렬

            for (int i = 0; i < list.Count; i++)//정방향 출력
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine();
            for (int i = list.Count -1; i >= 0 ; i--)//거꾸로 출력
            {
                Console.WriteLine(list[i]);
            }
        }
        
    }
}