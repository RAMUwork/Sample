using System;
namespace Algorithm_Practice {
    public class Question5 {
        public Question5() {
        }

        public void Action(int n) {
            Console.WriteLine("Hanoi {0:d}", n);
            Hanoi(n, "A", "B", "C");
        }

        private void Hanoi(int n, String left, String center, String right) {
            if (n > 0) {
                Hanoi(n - 1, left, right, center);
                Console.WriteLine("{0:s} to {1:s}", left, right);
                Hanoi(n - 1, center, left, right);
            }
        }
    }
}
