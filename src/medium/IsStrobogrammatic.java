package medium;

import java.util.HashMap;

public class IsStrobogrammatic {
    public boolean isStrobogrammatic(String num) {
        if (num == null || num.length() == 0) {
            return false;
        }
        HashMap<Character, Character> hashMap = new HashMap<>();
        initMap(hashMap);
        int l = 0;
        int r = num.length() - 1;

        if (num.length() % 2 == 1) {
            int m = l + (r - l) / 2;
            if (num.charAt(m) != '0' && num.charAt(m) != '1' && num.charAt(m) != '8') {
                return false;
            }
        }

        while (l < r) {
            char left = num.charAt(l);
            char right = num.charAt(r);
            if (hashMap.containsKey(left) && right == hashMap.get(left)) {
                l++;
                r--;
            } else {
                return false;
            }
        }

        return true;
    }

    private void initMap(HashMap<Character, Character> hashMap) {
        hashMap.put('0', '0');
        hashMap.put('1', '1');
        hashMap.put('6', '9');
        hashMap.put('8', '8');
        hashMap.put('9', '6');
    }
}
