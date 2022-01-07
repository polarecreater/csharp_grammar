using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: 복습
 * DESC: 자료구조 배열
 * 
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        //강의 코드
        
        static void Main(string[] args)
        {
            //배열
            int[] _array = new int[10];
            _array[1] = 2;
            _array[2] = 2;
            
            //로또 문제
            Random _rnd = new Random();
            for (int i = _array.Length-1; i > 3; i--)
            {
                _array[i] = _rnd.Next(1,46);
            }
            
            int _max = 0;//최댓값
            int _min = 50;//최솟값

            //출력
            for (int i = 0; i < _array.Length; i++)
            {
                if(_max<_array[i]){
                    _max = _array[i];
                }
                else if(_min>_array[i]){
                    _min = _array[i];
                }
                Console.Write(_array[i]);
                Console.Write(" ");
            }

            Console.WriteLine("최댓값: "+_max+" , 최솟값: "+_min);
            
            //결과 : 0 2 2 0 42 17 43 15 24 2 최댓값: 43 , 최솟값: 0
            


        }
        
    }
}