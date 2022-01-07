using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: 복습
 * DESC: 자료구조 List<T>
 * 
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        //강의 코드
        
        static void Main(string[] args)
        {
            //생성
            List<int> _gl = new List<int>();

            _gl.Add(2);
            _gl.Add(4);
            _gl.Add(8);
            _gl.RemoveAt(2);
            _gl.Append(99);
            int x = _gl.Max();
            int m = _gl.Min();

            //출력
            for(int i = 0; i<_gl.Count; i++){
                Console.Write(_gl[i] + " ");
            }  

            Console.WriteLine();

            _gl.Sort();
                      
            for(int i = 0; i<_gl.Count; i++){
                Console.Write(_gl[i]);
            }  
            Console.WriteLine(" max: "+ x + " , min: "+m);

            // If you prefer, you can create a new list explicitly
            List<int> newNumbers =_gl.Append(5).ToList();

            // And then write to the console output
            Console.WriteLine(string.Join(", ", newNumbers));//반복문 없이 출력 가능!

        }
        
    }
}