package medium;

/**
 * Created by shirui on 11/14/16.
 */
public class MyPow {
  public double myPow(double x, int n) {
    if (n == 0) return 1;
    if (x == 0) return 0;
    if (n < 0) {
      if (n == Integer.MIN_VALUE) ++n;
      n = -n;
      x = 1 / x;
    }
    return n % 2 == 0 ? myPow(x * x, n / 2) : x * myPow(x * x, n / 2);
  }
}
