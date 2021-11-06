package medium;

import java.util.ArrayList;
import java.util.LinkedList;

public class CanFinish {
    /**
     * can finish.
     *
     * @param numCourses
     * @param prerequisites
     * @return
     */
    public boolean canFinish(int numCourses, int[][] prerequisites) {
        // track out-degree of a course
        ArrayList<ArrayList<Integer>> courseDeps = new ArrayList<>();
        // track in-degree of a course
        int[] numsDeps = new int[numCourses];
        for (int i = 0; i < numCourses; i++) {
            courseDeps.add(new ArrayList<Integer>());
        }
        int count = numCourses;
        for (int[] pair : prerequisites) {
            // add course that is pre requ for pair[0]
            // 0,1 and 2,1
            // 1: 0,2
            courseDeps.get(pair[1]).add(pair[0]);
            numsDeps[pair[0]]++;
        }

        LinkedList<Integer> q = new LinkedList<>();
        for (int i = 0; i < numsDeps.length; i++) {
            // if no one depends on this course, send to q
            if (numsDeps[i] == 0) {
                q.offer(i);
                count--;
            }
        }

        while (!q.isEmpty()) {
            // this course has no one depends on
            int course = q.poll();
            // need to know after finish this course, which other courses to take
            for (int otherCourse : courseDeps.get(course)) {
                numsDeps[otherCourse]--;
                if (numsDeps[otherCourse] == 0) {
                    q.offer(otherCourse);
                    count--;
                }
            }
        }

        return count == 0;
    }
}
