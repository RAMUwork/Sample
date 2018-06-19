class Question4 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		int n = 1029;
		int m = 1071;
		System.out.printf("GCD(%d, %d) = %d\n", n, m, calcGCD(n, m));
	}

	static int calcGCD(int n, int m) {
		if (n == 0) {
			return m;
		} else {
			return calcGCD(m % n, n);
		}
	}
}
