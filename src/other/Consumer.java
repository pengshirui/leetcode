package other;

import java.util.LinkedList;
import java.util.concurrent.BlockingQueue;

public class Consumer implements Runnable {

  private BlockingQueue<Integer> queue;
  private int count = 0;
  private int name;

  public Consumer(BlockingQueue<Integer> queue, int name) {
    this.queue = queue;
    this.name = name;
  }

  @Override
  public void run() {
    while (count < 5) {

      if (queue.isEmpty()) {
        System.out.println("Consumer" + name + " queue is empty");
        try {
          Thread.sleep(1000);
        } catch (InterruptedException e) {
          e.printStackTrace();
        }
      } else {
        count++;
        System.out.println("Consumer" + name + " consumed " + count);
        int cur = queue.poll();
        System.out.println("Consumer" + name + " consumes: " + cur);
        try {
          Thread.sleep(cur * 600);
        } catch (InterruptedException e) {
          e.printStackTrace();
        }
      }
    }
    System.out.println("Consumer" + name + " quit");
  }
}
