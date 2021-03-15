using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Model
    {
        int a, c;
        public string S { get; set; }
        public string C { get; set; }

        private int P(string S)
        {
            int.TryParse(S, out a);
            return a;
        }

        public int Sum(int b)
        {
            a = P(S);
            return a + b;
        }

        public int Mult(int m)
        {
            a = P(S);
            return a * m;
        }
        public int Reset(int s) => a = s;

        public int Counter()
        {
            c = P(C);
            return c + 1;
        }

        public int CounterDown()
        {
            c = P(C);
            return c - 1;
        }

        public int ResetCounter() => c = 0;

        public int Cancel(int h)
        {
            a = P(S);
            return a = h;
        }

    }
}
