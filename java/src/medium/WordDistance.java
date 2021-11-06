package medium;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class WordDistance {

    private HashMap<String, List<Integer>> hm = new HashMap<>();

    public WordDistance(String[] words) {
        for (int i = 0; i < words.length; i++) {
            // store the index of word that appears in the array
            if (!hm.containsKey(words[i])) {
                List<Integer> list = new ArrayList<>();
                list.add(i);
                hm.put(words[i], list);
            } else {
                hm.get(words[i]).add(i);
            }
        }
    }

    public int shortest(String word1, String word2) {
        // using merge sort to get the short distance
        List<Integer> list1 = hm.get(word1);
        List<Integer> list2 = hm.get(word2);
        int res = Integer.MAX_VALUE;
        for (int i = 0, j = 0; i < list1.size() && j < list2.size() && res != 1; ) {
            int index1 = list1.get(i), index2 = list2.get(j);
            // increment the pointer for the smaller number
            if (index1 < index2) {
                res = Math.min(res, index2 - index1);
                i++;
            } else {
                res = Math.min(res, index1 - index2);
                j++;
            }
        }
        return res;
    }
}