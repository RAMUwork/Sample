class Question1 {
	// 正の整数nの階乗を求める(再帰処理)
	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		final int NUM = 5;
		System.out.println(NUM + "! = " + fact(NUM));
	}

	static int fact(int num) {
		if (num == 1) {
			return num;
		} else {
			return num * fact(num - 1);
		}
	}

}
