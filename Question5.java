class Question5 {

	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		final int N = 4;
		System.out.println("Hanoi " + N);
		hanoi (N, "A", "B", "C");
	}

	static void hanoi (int n, String left, String center, String right) {
		if (n > 0) {
			hanoi(n-1, left, right, center);
			System.out.println(left + " -> " + right);
			hanoi(n-1, center, left, right);
		}
	}
}
