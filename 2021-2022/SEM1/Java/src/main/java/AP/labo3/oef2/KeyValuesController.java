package AP.labo3.oef2;

import java.util.ArrayList;

public class KeyValuesController {
    public static void main(String[] args) {
        ArrayList<Integer> keys = new ArrayList<Integer>();
        keys.add(1);
        keys.add(5);
        keys.add(8);
        keys.add(12);
        ArrayList<String> values = new ArrayList<String>();
        values.add("Jef");
        values.add("Jens");
        values.add("Thomas");
        values.add("Jordi");
        values.add("Sam");

        KeyValues<Integer, String> keyValues = new KeyValues<Integer, String>(keys, values);

        System.out.print(keyValues + "\n");
        System.out.print(keyValues.getValue(8));
    }
}
