using System;
namespace Algorithm_Practice{
    class Question1 {
        public Question1() {
            
        }

        public void Action (int n) {
            Console.WriteLine("{0}! = {1}", n, Fact(n));
        }

        private int Fact (int n) {
            if (n == 0) {
                return 1;
            } else {
                return n * Fact(n - 1);
            }
        }
    }
}
