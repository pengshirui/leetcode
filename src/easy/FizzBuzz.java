package easy;

import java.util.ArrayList;
import java.util.List;

public class FizzBuzz {
    private static String THREE_X = "Fizz";
    private static String FIVE_X = "Buzz";
    private static String FIFTEEN_X = "FizzBuzz";
    public List<String> fizzBuzz(int n) {
        if (n == 0) {
            return new ArrayList<String>();
        }
        List<String> result = new ArrayList<>();
        for (int i = 0, three = 0, five = 0; i < n; i++) {
            three++;
            five++;
            if (three == 3 && five == 5) {
                result.add(FIFTEEN_X);
                three = 0;
                five = 0;
            } else if (three == 3) {
                result.add(THREE_X);
                three = 0;
            } else if (five == 0) {
                result.add(FIVE_X);
                five = 0;
            } else {
                result.add(String.valueOf(i));
            }

        }
        return result;
    }
}
