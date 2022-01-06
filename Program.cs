using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: ArrayList
 * DESC: 자료구조 ArrayList
 * 예시 코드
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        //강의 코드
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("문자열");//0번 데이터
            list.Add(100);//1번 데이터
            list.Add(true);//2번 데이터
            
            list.Insert(2,200);//2번 위치에 데이터 추가, 원래 2번->3번
            list.RemoveAt(1);//1변 데이터 삭제
            list.Remove("문자열"); //"문자열"에 해당하는 값 삭제

            for(int i = 0; i<list.Count; i++){//리스트 갯수만큼 반복
                Console.WriteLine(list[i]);
            }
        }
        
    }
}