package AP.labo3.oef6;

import java.util.HashSet;
import java.util.Set;

public class Controller {
    public static void main(String[] args) {
        HashSet<String> uniqueNames = new HashSet<>();

        uniqueNames.add("Jef");
        uniqueNames.add("Jef");

        System.out.print(uniqueNames.size());
    }
}
