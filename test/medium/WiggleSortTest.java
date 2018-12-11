package medium;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class WiggleSortTest {

    @Test
    public void testNull() {
        WiggleSort wiggleSort = new WiggleSort();
        wiggleSort.wiggleSort(null);
    }

    @Test
    public void testSort() {
        int[] a = {1, 2, 3, 4, 5};
        WiggleSort wiggleSort = new WiggleSort();
        wiggleSort.wiggleSort(a);

        int[] b = {1, 3, 2, 5, 4};
        for (int i = 0; i < a.length; i++) {
            Assertions.assertEquals(a[i], b[i]);

        }
    }

}
