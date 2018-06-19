class Question2 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		for (int i=1; i<=100; i++) {
			int num = fibo(i);

			if (num > 1000) {
				break;
			}
			System.out.printf("%3d ", num);
		}
		System.out.println();
	}

	static int fibo (int num) {
		if (num == 1 || num == 2) {
			return 1;
		} else {
			return fibo (num - 1) + fibo (num - 2);
		}
	}
}
