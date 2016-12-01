package stat;

import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.PriorityQueue;

public class ConstructorCost {
    private static Long alc, adc, llc, pqc;
    public static void arrayListCost() {
        Long start = System.nanoTime();
        new ArrayList();
        Long end = System.nanoTime();
        alc = average(alc , end - start);
        System.out.println("ArrayList: " + alc);
    }

    public static void arrayDequeCost() {
        Long start = System.nanoTime();
        new ArrayDeque();
        Long end = System.nanoTime();
        adc = average(adc , end - start);
        System.out.println("ArrayDeque: " + adc);
    }

    public static void linkedListCost() {
        Long start = System.nanoTime();
        new LinkedList();
        Long end = System.nanoTime();
        llc = average(llc , end - start);
        System.out.println("LinkedList: " + llc);
    }

    public static void priorityQueueCost() {
        Long start = System.nanoTime();
        new PriorityQueue();
        Long end = System.nanoTime();
        pqc = average(pqc , end - start);
        System.out.println("PriorityQueue: " + pqc);
    }

    private static Long average(Long l1, Long l2) {
        if (l1 == null || l1 == 0) return l2;
        return (l1 + l2) / 2;
    }


    public static void cost() {
        System.out.println("ALL COST");
        arrayListCost();
        linkedListCost();
        priorityQueueCost();
        arrayDequeCost();
        System.out.println();
    }


}
