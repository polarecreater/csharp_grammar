using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: _002_HelloWorld2
 * DESC: 메인 함수의 파라미터 보기
-----------------------------------------------------------------------------*/
namespace csharp_grammar
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;
            Console.WriteLine("Enter your first name: ");
            fname = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lname = Console.ReadLine();
            Console.WriteLine("Your full name is " + fname + lname);
        }
    }
}