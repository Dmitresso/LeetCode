public class Solution {
    public double MyPow(double x, int n) {
        return BinaryExp(x, n);

        double BinaryExp(double a, long m) {
            if (m == 0) return 1.0;
            if (m < 0) return 1 / BinaryExp(a, -m);
            return m % 2 == 0 ? BinaryExp(a * a, m / 2) : a * BinaryExp(a * a, (m - 1) / 2);
        }
    }
}