package easy;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class TwoSum {
  // order of a list
  private List<Integer> list = new ArrayList<>();
  // store the count of number
  private Map<Integer, Integer> map = new HashMap<>();

  // Add the number to an internal data structure.
  public void add(int number) {
    if (map.containsKey(number)) map.put(number, map.get(number) + 1);
    else {
      map.put(number, 1);
      list.add(number);
    }
  }

  // Find if there exists any pair of numbers which sum is equal to the value.
  public boolean find(int value) {
    for (Integer aList : list) {
      int num1 = aList, num2 = value - num1;
      // has the same number more than twice,
      // or difference number at least has one.
      if ((num1 == num2 && map.get(num1) > 1) || (num1 != num2 && map.containsKey(num2))) return true;
    }
    return false;
  }

  public int[] twoSum(int[] nums, int target) {
    int[] result = new int[2];
    HashMap<Integer, Integer> hm = new HashMap<>();
    for (int i = 0; i < nums.length; i++) {
      if (hm.containsKey(nums[i])) {
        result[0] = hm.get(nums[i]);
        result[1] = i;
        return result;
      } else {
        hm.put(target - nums[i], i);
      }
    }
    return result;
  }
}
