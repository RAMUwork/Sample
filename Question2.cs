using System;
namespace Algorithm_Practice {
    class Question2 {
        public Question2() {
        }

        public void Action(int n) {
            Console.WriteLine("Fibonacci: " + n + "// Fibo(n) < 1,000");
            for (int i = 1; i <= n; i++) {
                int fibo = Fibo(i);

                if (fibo > 1000) {
                    break;
                }
                Console.Write("{0:d} ", fibo);
            }
            Console.WriteLine();
        }

        private int Fibo(int n) {
            if (n == 1 || n == 2) {
                return 1;
            } else {
                return Fibo(n - 1) + Fibo(n - 2);
            }
        }
    }
}
