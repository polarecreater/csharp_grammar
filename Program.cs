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
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            //list.Add(22);//데이터 타입이 맞지 않아 오류

            list.Insert(1,"c");//삽입
            list.Remove("a");//값 삭제
            list.RemoveAt(1);//순서 삭제

            for (int i = 0; i < list.Count; i++)
            {   
                Console.WriteLine(list[i]);//출력
                
            }

        }
        
    }
}