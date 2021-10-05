package AP.labo3.oef2;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class KeyValues<T1, T2> {
    private HashMap<T1, T2> map = new HashMap<T1, T2>();

    public T2 getValue(T1 key) {
        return map.get(key);
    }

    public KeyValues(ArrayList<T1> keys, ArrayList<T2> values) {
        for (int i = 0; i < Math.min(keys.size(), values.size()); i++) {
            map.put(keys.get(i), values.get(i));
        }
    }

    @Override
    public String toString() {
        return "KeyValues{" +
                "map=" + map +
                '}';
    }
}
