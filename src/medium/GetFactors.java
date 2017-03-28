package medium;

import java.util.ArrayList;
import java.util.List;

public class GetFactors {
  public List<List<Integer>> getFactors(int n) {
    List<List<Integer>> result = new ArrayList<>();
    if (n < 4) {
      return result;
    }
    List<Integer> list = new ArrayList<>();
    helper(result, list, n, 2);
    return result;
  }

  private void helper(List<List<Integer>> result, List<Integer> list, int n, int start) {
    for (int i = start; i * i <= n; i++) {
      if (n % i == 0) {
        list.add(i);
        helper(result, list, n / i, i);
        list.add(n / i);
        result.add(new ArrayList<>(list));
        // remove last two int so it can be re calculate in to new combination
        list.remove(list.size() - 1);
        list.remove(list.size() - 1);
      }
    }
  }
}
