using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "문" + "혜" + "경";
            Console.Write("Hello C#");
            int add = 2;
            int Alpha;
            // 주석
            /*
             * 
             * 여러 줄 주석
             * 
             */
            Console.WriteLine("HelloWorld");
            Console.Write("HelloWorld");


            Console.WriteLine(7 % 3);

            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"");

            Console.WriteLine("가나" + "다라마바" + "사아" + "자차카" + "타파하");

            Console.WriteLine("안녕하세요"[100]);

            Console.WriteLine(true);
            Console.WriteLine(false);
        }
    }
}
