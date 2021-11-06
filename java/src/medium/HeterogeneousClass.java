package medium;

import java.util.HashMap;
import java.util.Map;
import java.util.TreeSet;

public class HeterogeneousClass {
    private Map<Class<?>, Object> map = new HashMap<Class<?>, Object>();
    private TreeSet<Class<?>> treeSet = new TreeSet<>();

    public <T> void put(Class<T> t) {
        treeSet.add(t);
    }

    public <T> T get(Class<T> type) {
        return type.cast(map.get(type));
    }
}
