package medium;

import java.util.HashMap;

public class TotalFruit {
    public int totalFruit(int[] tree) {
        // Final result
        int ans = 0;
        // Left most index
        int i = 0;
        Counter count = new Counter();
        for (int j = 0; j < tree.length; ++j) {
            // Add one to a type
            count.add(tree[j], 1);
            // If the bucket has more than three types
            while (count.size() >= 3) {
                // Remove one from the type of the left most
                count.add(tree[i], -1);
                // If type of the left most no longer in the bucket, throw out
                if (count.get(tree[i]) == 0) {
                    count.remove(tree[i]);
                }
                i++;
            }
            // track the current longest
            ans = Math.max(ans, j - i + 1);
        }

        return ans;
    }
}

// HashMap with type and count
class Counter extends HashMap<Integer, Integer> {
    public int get(int k) {
        return containsKey(k) ? super.get(k) : 0;
    }

    public void add(int k, int v) {
        put(k, get(k) + v);
    }
}
