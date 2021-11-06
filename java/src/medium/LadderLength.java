package medium;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.LinkedList;
import java.util.Set;

public class LadderLength {
    public int ladderLengthI(String beginWord, String endWord, Set<String> wordList) {
        if (wordList == null) return 0;
        if (beginWord.equals(endWord)) return 1;

        wordList.add(beginWord);
        wordList.add(endWord);

        HashSet<String> hs = new HashSet<>();
        LinkedList<String> q = new LinkedList<>();
        q.offer(beginWord);
        hs.add(beginWord);
        int c = 1;
        while (!q.isEmpty()) {
            int size = q.size();
            c++;
            for (int i = 0; i < size; i++) {
                String cur = q.poll();
                for (String word : getNextWords(cur, wordList)) {
                    if (word.equals(endWord)) return c;
                    if (!hs.contains(word)) {
                        q.offer(word);
                        hs.add(word);
                    }
                }
            }
        }

        return 0;
    }

    private HashSet<String> getNextWords(String word, Set<String> wordList) {
        HashSet<String> result = new HashSet<>();
        for (char c = 'a'; c <= 'z'; c++) {
            for (int i = 0; i < word.length(); i++) {
                if (c == word.charAt(i)) {
                    continue;
                }
                String newWord = replace(word, i, c);
                if (wordList.contains(newWord)) {
                    result.add(newWord);
                }
            }
        }
        return result;
    }

    private String replace(String word, int pos, char c) {
        char[] chars = word.toCharArray();
        chars[pos] = c;
        return new String(chars);
    }

    public int ladderLengthII(String beginWord, String endWord, Set<String> wordList) {
        Set<String> beginSet = new HashSet<>(), endSet = new HashSet<>();

        int len = 1;
        HashSet<String> visited = new HashSet<>();

        beginSet.add(beginWord);
        endSet.add(endWord);
        while (!beginSet.isEmpty() && !endSet.isEmpty()) {

            // start with the smaller set
            if (beginSet.size() > endSet.size()) {
                Set<String> set = beginSet;
                beginSet = endSet;
                endSet = set;
            }

            Set<String> temp = new HashSet<>();
            for (String word : beginSet) {
                char[] chs = word.toCharArray();

                for (int i = 0; i < chs.length; i++) {
                    for (char c = 'a'; c <= 'z'; c++) {
                        char old = chs[i];
                        chs[i] = c;
                        String target = new String(chs);

                        if (endSet.contains(target)) {
                            return len + 1;
                        }

                        if (!visited.contains(target) && wordList.contains(target)) {
                            temp.add(target);
                            visited.add(target);
                        }
                        chs[i] = old;
                    }
                }
            }

            beginSet = temp;
            len++;
        }

        return 0;
    }
}
