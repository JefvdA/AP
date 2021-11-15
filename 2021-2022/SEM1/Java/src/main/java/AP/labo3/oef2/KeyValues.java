package AP.labo3.oef2;

import java.util.*;

public class KeyValues<T1, T2> {
    private Set<T1> keys;
    private List<T2> values;

    public KeyValues() {
        this.keys = new LinkedHashSet<>();
        this.values = new ArrayList<>();
    }

    public void addValue(T1 key, T2 value){
        if(key != null) {
            if (keys.add(key))
                values.add(value);
        }
    }

    public T2 getValue(T1 key){
        int count = 0;
        for(T1 item : keys){
            if(item.equals(key))
                return values.get(count);
            count++;
        }
        return null;
    }
}
