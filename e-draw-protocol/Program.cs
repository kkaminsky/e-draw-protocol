using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Math;

namespace e_draw_protocol
{
    class Program
    {
        static BigInteger h(BigInteger r1, BigInteger r2, BigInteger b)
        {
            return BigInteger.Ten.Multiply(r1).Add(BigInteger.Three.Multiply(r2)).Add(BigInteger.Two.Multiply(b));
        }
        static void Main(string[] args)
        {

            BigInteger r1 = BigInteger.ProbablePrime(256, new Random());

            Console.WriteLine("r1 :"+ r1);

            BigInteger r2 = BigInteger.ProbablePrime(256, new Random());

            Console.WriteLine("r2 :"+ r2);

            BigInteger b = BigInteger.One;

            Console.WriteLine("b :"+ b);

            Console.WriteLine("---Этап привязки---");

            BigInteger y1 = h(r1, r2, b);

            Console.WriteLine("y1 :" + y1 + " r1 :" + r1);

            Console.WriteLine("---Этап раскрытия---");

            Console.WriteLine("r2 :" + r2 + " b :" + b);

            BigInteger y2 = h(r1, r2, b);

            Console.WriteLine("y2: " + y2);

            Console.ReadKey();

        }
    }
}
