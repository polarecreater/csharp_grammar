using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: 버블 정렬
 * DESC: 자료구조 버블 정렬
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
            for (int i = 0; i < data.Length; i++)//전체 순회
            {
                for (int j = 0; j < data.Length-1-i; j++)//비교
                {
                    if(data[j]>data[j+1]){
                        Swap(ref data[j], ref data[j+1]);
                    }
                    Console.Write((i+1) +"번째 정렬값 (" + j + ", " +(j+1) + "): ");
                    //전체 출력
                    for (int k = 0; k < data.Length; k++)
                    {
                        Console.Write(data[k].ToString() + ", ");
                    }
                    Console.WriteLine();
                }
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