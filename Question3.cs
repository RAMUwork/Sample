using System;
namespace Algorithm_Practice {
    class Question3 {
        public Question3() {
        }

        public void Action(int n) {
            CalcNumber(n);
        }

        private void CalcNumber(int n) {
            if (n == 1) {
                Console.WriteLine("{0,3:d}: END", n);
            } else {
                if (n % 2 == 0) {
                    Console.WriteLine("{0,3:d}: {0:d} / 2", n);
                    CalcNumber(n / 2);
                } else {
                    Console.WriteLine("{0,3:d}: 3 * {0:d} + 1", n);
                    CalcNumber(3 * n + 1);
                }
            }
        }
    }
}
