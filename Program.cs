using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: 삽입 정렬
 * DESC: 자료구조 삽입 정렬
 * 
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        //강의 코드
        static void Main(string[] args)
        {
            
            int[] data = {20,15,1,5,10};
            Console.Write("시작값: ");
            for (int i = 0; i < data.Length; i++)
            {
                int key = i;

                //앞에 있는 값과 비교
                for (int j = i-1; j>=0; j--)
                {
                    if(data[key] < data[j]){
                        Swap(ref data[j], ref data[key]);
                        key = j;
                    }else{
                        break;
                    }
                }
                //출력해서 확인
                for (int j = 0; j < data.Length; j++)
                {
                    Console.Write(data[j] + " , ");
                }
                Console.WriteLine();
            }
        }
        //교환 함수 필요
        static void Swap(ref int a, ref int b){
            //ref : call by reference : 이 주소로 가서 실제 값을 바꿈
            //ref가 없으면 이 내부에서만 값 변경이 되고 실제 배열에서 값이 변경되지 않음

            int temp = a;
            a = b;
            b = temp;
        }
    }
}