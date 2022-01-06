using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: Q_Lotto
 * DESC: 자료구조 배열
 * 로또 번호 6자리 중복 없이 추출
 * 데이터 : int[] 번호;
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        //강의 코드
        static void Main(string[] args)
        {
            Program test = new Program();
        }
        
        private int[] number;//클래스 변수 선언
        public Program(){//생성자
            GetNumber();//함수 실행
        }
        private void GetNumber(){
            Random rnd = new Random();//랜덤 함수
            number = new int[6];//함수 안에서 배열 초기화
            int index = 0;
            while(index<number.Length){
                int temp = rnd.Next(1,46);
                if(IsSameNumber(index, temp)){
                    continue;//아래 코드 실행 건너뛰기 //true면 temp 다시 뽑음
                }
                number[index++] = temp;
            }
            for (int i = 0; i<number.Length; i++){//로또 번호 출력
                Console.WriteLine(number[i]);
            }
        }
        private bool IsSameNumber(int index, int temp){//중복 여부 확인
            for (int i = 0; i<index; i++){
                if(number[i] == temp)
                    return true;
            }
            return false;
        }
    }
}