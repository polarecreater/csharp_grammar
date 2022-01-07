using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: Hashtable, Dictionary<T>
 * DESC: 자료구조 Hashtable, Dictionary<T>
 * 
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        //강의 코드
        static void Main(string[] args)
        {
            //해쉬 테이블
            Hashtable hash = new Hashtable();
            hash.Add(0, "하지");
            hash.Add(1, "동지");
            hash.Add(2, "소한");
            hash.Add(3, "대한");
            Console.WriteLine(hash[3]);//key를 인덱스처럼 사용 가능

            //딕셔너리
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("하지","001");
            dic.Add("동지","002");
            dic.Add("소한","003");
            dic.Add("대한","004");

            // //딕셔너리는 중복이 안됨
            // dic.Add("하지","006");//넣어지지 않음

            //키가 이미 있는지 확인
            if(!dic.ContainsKey("경칩")){
                dic.Add("경칩","005");
            }

            //삭제
            dic.Remove("소한");
            
            foreach (var item in dic.Keys)//키 개수만큼 반복
            {
                Console.WriteLine(item + ": " + dic[item]);
            }
        }
    }
}