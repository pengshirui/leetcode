package medium;

public class SearchMatrix {
  public boolean searchMatrixI(int[][] matrix, int target) {
    if (matrix == null || matrix.length == 0 || matrix[0].length == 0) {
      return false;
    }
    int row = matrix.length, col = matrix[0].length;
    int l = 0, r = col * row - 1;
    while (l + 1 < r) {
      int m = l + (r - l) / 2;
      int val = matrix[m / col][m % col];
      if (val == target) {
        return true;
      } else if (val > target) {
        r = m;
      } else {
        l = m;
      }
    }
    return matrix[l / col][l % col] == target || matrix[r / col][r % col] == target;
  }

  /**
   * Integers in each row are sorted in ascending from left to right.
   * Integers in each column are sorted in ascending from top to bottom.
   */
  public boolean searchMatrixII(int[][] matrix, int target) {
    if (matrix == null || matrix.length == 0 || matrix[0].length == 0) {
      return false;
    }
    int row = 0, col = matrix[0].length - 1;
    while (row <= matrix.length - 1 && col >= 0) {
      int val = matrix[row][col];
      if (val == target) {
        return true;
      } else if (val > target) {
        col--;
      } else {
        row++;
      }
    }
    return false;
  }


}
