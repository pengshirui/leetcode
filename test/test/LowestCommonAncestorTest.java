package test;

import common.TreeNode;
import easy.LowestCommonAncestor;
import org.junit.Assert;
import org.junit.Test;

public class LowestCommonAncestorTest {

    @Test
    public void testNull(){
        LowestCommonAncestor lowestCommonAncestor = new LowestCommonAncestor();
        TreeNode treeNode = lowestCommonAncestor.lowestCommonAncestor(null, null, null);
        Assert.assertNull(treeNode);
    }
}