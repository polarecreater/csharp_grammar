using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: 선택 정렬
 * DESC: 자료구조 선택 정렬
 * 
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        //강의 코드
        static void Main(string[] args)
        {
            //배열 출력
            int[] data = {20,15,1,5,10};
            Console.Write("시작값: ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + ", ");
            }
            Console.WriteLine();

            //정렬
            for (int i = 0; i < data.Length; i++)
            {
                int min = i;
                //최솟값 찾기
                for (int j = i+1; j < data.Length; j++)
                {
                    if(data[min]>data[j]){
                        min = j;
                    }
                }
                Swap(ref data[i],ref data[min]);//주소(레퍼런스) 값을 넘김
            }
            
            //출력
            Console.Write("정렬 값 : ");
            for (int k = 0; k < data.Length; k++)
            {
                Console.Write(data[k]+ ", ");
            }
            Console.WriteLine();
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