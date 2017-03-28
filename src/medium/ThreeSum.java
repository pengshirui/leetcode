package medium;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

// https://leetcode.com/problems/3sum/
public class ThreeSum {
  public List<List<Integer>> threeSum(int[] nums) {
    List<List<Integer>> result = new ArrayList<>();
    if (nums == null) {
      return result;
    }
    Arrays.sort(nums);  // O(nlogn)
    for (int i = 0; i < nums.length - 2; i++) { // O(n2)
      // skip dups
      if (i == 0 || (i > 0 && nums[i] != nums[i - 1])) {
        int l = i + 1;
        int r = nums.length - 1;
        int t = 0 - nums[i];
        while (l < r) {
          if (nums[l] + nums[r] == t) {
            List<Integer> list = new ArrayList<>();
            list.add(nums[i]);
            list.add(nums[l]);
            list.add(nums[r]);
            result.add(list);
            while (l < r && nums[l] == nums[l + 1]) l++;    // skip dups
            while (l < r && nums[r] == nums[r - 1]) r--;    // skip dups
            l++;
            r--;
          } else if (nums[l] + nums[r] > t) {
            r--;
          } else {
            l++;
          }
        }
      }
    }
    return result;
  }
}
