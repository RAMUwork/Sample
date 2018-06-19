class Question6 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		final int N = 8;
		int[] result = new int[N];
		nQueen(0, new int[N], new boolean[N], result);

		System.out.println(N + " Queen");
		for (int i = 0; i < result.length; i++) {
			System.out.printf("(%d, %d) ", i + 1, result[i]);
		}
		System.out.println();
	}

	static void nQueen(int n, int[] num, boolean[] flag, int[] result) {
		if (n == num.length) {
			if (checkQueen(num)) {
				for (int i = 0; i < result.length; i++) {
					result[i] = num[i];
				}
			}
		} else {
			for (int i = 1; i <= num.length; i++) {
				if (flag[i - 1]) {
					continue;
				}

				num[n] = i;
				flag[i - 1] = true;
				nQueen(n + 1, num, flag, result);
				flag[i - 1] = false;
			}
		}
	}

	static boolean checkQueen(int[] num) {
		int k = 1;
		for (int i = 0; i < num.length; i++) {
			k = 1;
			for (int j = i + 1; j < num.length; j++) {
				if ((num[i] == num[j] + k) || (num[i] == num[j] - k)) {
					return false;
				}
				k++;
			}
		}
		return true;
	}
}
