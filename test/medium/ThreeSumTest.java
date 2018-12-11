package medium;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;


public class ThreeSumTest {

    @Test
    public void testNull() {
        ThreeSum threeSum = new ThreeSum();
        Assertions.assertNotNull(threeSum.threeSum(null));
    }
}