class Question3 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		calcNum(100);
	}

	static void calcNum(int num) {
		if (num == 1) {
			System.out.printf("n=%d: END\n", num);
		} else {
			if (num % 2 == 0) {
				System.out.printf("n=%d: %d / 2\n", num, num);
				calcNum(num / 2);
			} else {
				System.out.printf("n=%d: %d * 3 + 1\n", num, num);
				calcNum(num * 3 + 1);
			}
		}
	}
}
