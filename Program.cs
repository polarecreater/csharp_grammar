using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*-----------------------------------------------------------------------------
 * Name: 퀵 정렬
 * DESC: 퀵 정렬 복습
 * 맨 앞을 피봇으로 코드 변경
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        static int[] data = { 25, 15, 60, 45, 10, 20, 5, 30};

        static void Main(string[] args){
            Console.Write("시작값 : ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i].ToString() + ", ");
            }
            Console.WriteLine();
            SortQuick(0, data.Length -1);
            Console.Write("정렬값 : ");

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i].ToString() + ",");
            }
            Console.WriteLine();
        }
        static void SortQuick(int nFirst, int nLast){
            
            if (nFirst<nLast){
                int pivotIndex = FuncPartition(nFirst, nLast);
                
                //분할
                SortQuick(nFirst, pivotIndex - 1);
                SortQuick(pivotIndex + 1, nLast);
            }
        }
        static int FuncPartition(int nFirst, int nLast){
            int nLow, nHigh, nPivot;

            //임의의 값 - 여기서는 첫번째 값
            nPivot = data[nFirst];

            nLow = nFirst+1;
            nHigh = nLast;

            Console.WriteLine("Low : " + data[nLow] + ", High : " + data[nHigh]);
            
            while(nLow <= nHigh){
                while (data[nLow] < nPivot){
                    nLow++;
                    Console.WriteLine("Low Change : "+data[nLow]);
                }
                while (data[nHigh] > nPivot){
                    nHigh--;
                    Console.WriteLine("High Change : "+data[nHigh]);
                }
                if(nLow <= nHigh){
                    Swap(data, nLow, nHigh);
                }
                Console.WriteLine("Low : " + data[nLow] + ", High : " + data[nHigh]);

            }
            Swap(data, nHigh, nFirst);

            Console.Write("정렬값 (Pivot : " + nPivot + ") : ");
            
            for (int i = 0; i < data.Length; i++)
            {
                if(nPivot == data[i])
                    Console.Write("*" + data[i] + "*, ");
                else
                    Console.Write(data[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            return nHigh;
        }
        static void Swap(int[] nArrData, int nValue1, int nValue2){
            int nTemp = nArrData[nValue1];
            nArrData[nValue1] = nArrData[nValue2];
            nArrData[nValue2] = nTemp;

            Console.WriteLine("Swap : " + nArrData[nValue1]+" , "+ nArrData[nValue2]);
        }
    }
}
