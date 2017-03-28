package basics;

/**
 * Created by yizhu on 1/15/17.
 */
public class Sort {

    public void quickSort(int[] A, int low, int high){
        if(low < high){
            int pivot = partition(A, low, high);
            quickSort(A,low, pivot-1);
            quickSort(A, pivot + 1, high);
        }
    }

    int partition(int[] A, int low, int high){
        if(low < high){
            int i = low -1;
            for(int j=low; j< high; j++){
                if(A[j] <= A[high]){
                    i++;
                    swap(A,i,j);
                }
            }
            swap(A,i+1,high);
            return i + 1;
        }
        return low;
    }

    void swap(int[] A, int i, int j){
        int temp = A[i];
        A[i] = A[j];
        A[j] = temp;
    }
}
