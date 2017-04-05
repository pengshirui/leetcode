package medium;

import org.junit.Assert;
import org.junit.Test;

public class ThreeSumTest {

    @Test
    public void testNull() {
        ThreeSum threeSum = new ThreeSum();
        Assert.assertNotNull(threeSum.threeSum(null));
    }
}