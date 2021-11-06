package easy;

public class ShortestDistance {
    public int shortestDistance(String[] words, String word1, String word2) {
        int w1 = Integer.MAX_VALUE, w2 = Integer.MAX_VALUE;
        int min = Integer.MAX_VALUE;
        int p = 0;
        while (p < words.length) {
            if (words[p].equals(word1)) {
                min = Math.min(min, Math.abs(w2 - p));
                w1 = p;
            } else if (min == 1) {
                return 1;
            } else if (words[p].equals(word2)) {
                min = Math.min(min, Math.abs(w1 - p));
                w2 = p;
            }
            p++;
        }
        return min;
    }
}
