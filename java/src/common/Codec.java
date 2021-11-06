package common;

import java.util.Arrays;
import java.util.Deque;
import java.util.LinkedList;

/**
 * @see <a href="https://leetcode.com/problems/serialize-and-deserialize-binary-tree/#/description">Codec</a>
 */
public class Codec {
    private static final String spliter = ",";
    private static final String NN = "#";

    /**
     * Serialize.
     *
     * @param root treenode
     * @return string
     */
    public static String serialize(TreeNode root) {
        StringBuilder sb = new StringBuilder();
        buildString(root, sb);
        return sb.toString();
    }

    // DFS
    private static void buildString(TreeNode treeNode, StringBuilder sb) {
        if (treeNode == null) {
            sb.append(NN).append(spliter);
        } else {
            sb.append(treeNode.val).append(spliter);
            buildString(treeNode.left, sb);
            buildString(treeNode.right, sb);
        }
    }

    /**
     * Deserialize.
     *
     * @param data string
     * @return treenode
     */
    public static TreeNode deserialize(String data) {
        Deque<String> nodes = new LinkedList<>();
        nodes.addAll(Arrays.asList(data.split(spliter)));
        return buildTree(nodes);
    }

    private static TreeNode buildTree(Deque<String> nodes) {
        String val = nodes.pop();
        if (val.equals(NN)) {
            return null;
        } else {
            TreeNode node = new TreeNode(Integer.valueOf(val));
            node.left = buildTree(nodes);
            node.right = buildTree(nodes);
            return node;
        }
    }
}
