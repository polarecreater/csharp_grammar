using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: Q_Snail
 * DESC: 자료구조 오티 달팽이 문제
 * 땅 위에 달팽이가 있다. 이 달팽이는 높이가 10미터인 나무를  올라가는 중이다. 
 * 달팽이는 낮에 3미터를 올라가고, 밤 잠을 자는 동안 2미터를 미끄러진다.
 * 달팽이가 나무를 모두 올라가려면 며칠이 걸리는지 구하시오.
 * 데이터 : int 낮 = 3; int 밤 = -2; int 나무 = 10;
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 3;//올라가는 높이
            int night = 2;//내려가는 높이
            int tree = 10;//나무 높이
            int goup = 0;//현재 높이
            int daynum = 0;//걸린 날짜
            /*
            //내가 쓴 코드 
            while(goup <= tree){
                daynum++;
                goup += day;
                //여기에서 비교를 해야 함
                goup -= night;
                Console.Write(daynum);
            }
            Console.WriteLine();
            Console.WriteLine(daynum);
            */
            
            while(true){
                daynum++;
                goup += day;
                if(goup >= tree){
                    break;
                }
                goup -= night;
                Console.Write(daynum);
            }
            Console.WriteLine();
            Console.WriteLine(daynum);
            
        }
    }
}