package medium;

import common.DirectedGraphNode;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.LinkedList;

public class TopSort {
  public ArrayList<DirectedGraphNode> topSort(ArrayList<DirectedGraphNode> graph) {
    if (graph == null || graph.isEmpty()) return null;
    ArrayList<DirectedGraphNode> result = new ArrayList<>();
    HashMap<DirectedGraphNode, Integer> map = new HashMap<>();
    for (DirectedGraphNode node : graph) {
      for (DirectedGraphNode neighbor : node.neighbors) {
        if (map.containsKey(neighbor)) {
          // add number of dependency of each node
          map.put(neighbor, map.get(neighbor) + 1);
        } else {
          map.put(neighbor, 1);
        }
      }
    }

    LinkedList<DirectedGraphNode> q = new LinkedList<>();
    for (DirectedGraphNode node : graph) {
      // add 0 incoming edge node to the queue
      if (!map.containsKey(node)) {
        q.offer(node);
        result.add(node);
      }
    }

    while (!q.isEmpty()) {
      DirectedGraphNode cur = q.poll();
      for (DirectedGraphNode neighbor : cur.neighbors) {
        map.put(neighbor, map.get(neighbor) - 1);
        if (map.get(neighbor) == 0) {
          // no incoming edge
          q.offer(neighbor);
          result.add(neighbor);
        }
      }
    }
    return result;
  }
}
