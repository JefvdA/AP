package AP.labo7.oef1;

import java.util.Arrays;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        List<String> names = Arrays.asList("peter", "anna", "mike", "xenia");

        Collections.sort(names, (a, b) -> {
            return b.compareTo(a);
        });

        for(String name : names){
            System.out.println(name);
        }
    }
}
