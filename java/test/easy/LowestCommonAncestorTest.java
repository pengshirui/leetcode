package easy;


import common.TreeNode;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class LowestCommonAncestorTest {

  @Test
  public void testNull() {
    LowestCommonAncestor lowestCommonAncestor = new LowestCommonAncestor();
    TreeNode treeNode = lowestCommonAncestor.lowestCommonAncestor(null, null, null);
    Assertions.assertNull(treeNode);
  }
}