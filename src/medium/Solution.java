package medium;

import java.util.Random;

public class Solution {
    int[] origin;
    Random random;

    public Solution(int[] nums) {
        origin = nums;
        random = new Random();
    }

    /**
     * Resets the array to its original configuration and return it.
     */
    public int[] reset() {
        return this.origin;
    }

    /**
     * Returns a random shuffling of the array.
     */
    public int[] shuffle() {
        if (origin == null || origin.length < 1) return origin;
        int[] t = origin.clone();
        for (int i = 0; i < t.length; i++) {
            int j = random.nextInt(i + 1);
            int temp = t[i];
            t[i] = t[j];
            t[j] = temp;
        }
        return t;
    }
}
