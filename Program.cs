using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: Queue
 * DESC: 자료구조 원형 Queue를 배열로 구현
 * 데이터: int front, rear, index; 배열;
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        //강의 코드
        static int[] m_queue = new int[5];//왜 static?
        static int front = -1;
        static int rear = -1;
        
        static void Main(string[] args)
        {
            Enqueue(10);
            Enqueue(20);
            Enqueue(30);
            Enqueue(40);
            Enqueue(50);

            Dequeue();

            Enqueue(60);//데이터 꽉 참

            Enqueue(70);//들어가지 않음

            Dequeue();
            Dequeue();
            Dequeue();

            Enqueue(80);
            Enqueue(90);
            
            Dequeue();
            Dequeue();
            Dequeue();
            for (int i = 0; i < m_queue.Length; i++)
            {
                Console.WriteLine("Index" + i + " - " + m_queue[i]);
            }
        }
        private static void Enqueue(int value){
            rear++;

            //데이터 꽉 찾을 때 대비
            if(rear - front>m_queue.Length -1){//배열의 값 넘어간 경우
                rear--;//원상 복귀
                return;//데이터 넣지 않은 상태로 리턴
            }
            m_queue[rear%m_queue.Length] = value;//배열 인덱스 꽉 찼을 때 대비

            if(front == -1)//처음 수가 들어올 때
                front = 0;
        }
        private static void Dequeue(){
            if(front == -1){//아무것도 없을 때
                return;
            }
            int value = m_queue[front%m_queue.Length];//dequeue를 무한정으로 할 경우
            Console.WriteLine("Dequeue - "+value);
            m_queue[front % m_queue.Length] = 0;
            front++;

            if(front>rear){//데이터 다 뽑아낸 경우
                front = -1;
                rear = -1;
            }
        }
    }
}