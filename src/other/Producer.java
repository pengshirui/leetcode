package other;

import java.util.LinkedList;
import java.util.Random;
import java.util.concurrent.BlockingQueue;

/**
 * Created by shirui on 11/5/16.
 */
public class Producer implements Runnable {

    private BlockingQueue<Integer> queue;
    private int size, count;
    private Random random;

    public Producer(BlockingQueue<Integer> queue, int size) {
        this.queue = queue;
        this.size = size;
        random = new Random();
    }


    @Override
    public void run() {
        while (count < 15) {

            if (queue.size() == size) {
                System.out.println("Producer queue is full");
                try {
                    Thread.sleep(1000);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            } else {
                count++;
                System.out.println("Producer produced: " + count);

                int k = random.nextInt(10) + 1;
                queue.offer(k);
                System.out.println("Producer produce: " + k);
                try {
                    Thread.sleep(1000);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        }
        System.out.println("Producer quit");
    }
}
