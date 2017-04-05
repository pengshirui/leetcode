package basic;

public class Sort {
    /**
     * quick sort.
     *
     * @param array array
     * @param low   left pointer
     * @param high  right pointer
     */
    public void quickSort(int[] array, int low, int high) {
        if (low < high) {
            int pivot = partition(array, low, high);
            quickSort(array, low, pivot - 1);
            quickSort(array, pivot + 1, high);
        }
    }

    private int partition(int[] arr, int low, int high) {
        if (low < high) {
            int i = low - 1;
            for (int j = low; j < high; j++) {
                if (arr[j] <= arr[high]) {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return i + 1;
        }
        return low;
    }

    private void swap(int[] arr, int i, int j) {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
