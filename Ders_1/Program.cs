using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;                                                  //  a değişkenini sıfıra atadık

            if (a > 0)                                                  // bir koşul oluşturduk ve bu koşula a sıfırdan büyükse dedik 
            {
                Console.WriteLine("a pozitif bir tam sayıdır");
            }
            else if (a < 0)                                             // burda da a 'nın sıfırdan küçük olma durumunu ele aldık
            {
                Console.WriteLine(" a negatif bir tam sayıdır ");
            }
            else                                                        // burda da a 'nın sıfıra eşit oldugu durumu ele aldık
            {
                Console.WriteLine("a sayası sıfırdır");
            }
            Console.ReadKey();
        }
    }
}
