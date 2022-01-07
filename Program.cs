using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: 복습
 * DESC: 자료구조 ArrayList
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
            ArrayList _al = new ArrayList();
            _al.Add("가족");
            _al.Add(4);
            _al.Add(-0);

            _al.Remove(-0);

            _al.Insert(2,"hope");

            //출력
            for(int i = 0; i<_al.Count; i++){
                Console.Write(_al[i]);
            }            
            
        }
        
    }
}