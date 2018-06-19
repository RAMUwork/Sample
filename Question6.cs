using System;
namespace Algorithm_Practice {
    class Question6 {
        int count = 0;
        public Question6() {
        }

        public void Action(int n) {
            NQueen(0, new int[n], new bool[n]);
        }

        private void NQueen(int n, int[] num, bool[] flag) {
            if (n == num.Length) {
                if (CheckQueen(num)) {
                    count++;
                    Console.Write("{0,2:d}: ", count);
                    for (int i = 0; i < num.Length; i++) {
                        Console.Write("({0:d},{1:d}) ", i + 1, num[i]);
                    }
                    Console.WriteLine();
                }
            } else {
                for (int i = 1; i <= num.Length; i++) {
                    if (flag[i - 1]) {
                        continue;
                    }

                    num[n] = i;
                    flag[i - 1] = true;
                    NQueen(n + 1, num, flag);
                    flag[i - 1] = false;
                }
            }
        }

        private bool CheckQueen(int[] num) {
            for (int i = 0; i < num.Length; i++) {
                int queen = num[i];
                int k = 1;
                for (int j = i + 1; j < num.Length; j++) {
                    if (num[j] == num[i] + k || num[j] == num[i] - k) {
                        return false;
                    }
                    k++;
                }
            }
            return true;
        }
    }
}
