using System;
namespace Algorithm_Practice {
    class Question4 {
        public Question4() {
        }

        public void Action(int n, int m) {
            if (m > n) {
                int tmp = m;
                m = n;
                n = tmp;
            }

            Console.WriteLine("GCD({0:d},{1:d}) = {2:d}", n, m, CalcGCD(n, m));
        }

        private int CalcGCD(int n, int m) {
            if (n == 0) {
                return m;
            } else {
                return CalcGCD(m % n, n);
            }
        }
    }
}
