package AP.labo7.oef4;

import AP.labo7.Person;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        List<Person> lectorenLijst = new ArrayList<>();
        lectorenLijst.add(new Person("Kelly", "Casal", "kelly.casalmosteiro@ap.be"));
        lectorenLijst.add(new Person("Olga", "Coutrin", "olga.coutrin@ap.be"));
        lectorenLijst.add(new Person("Philippe", "Possemiers", "philippe.possemiers@ap.be"));
        System.out.println("\n=== print Name with stream ===");

        lectorenLijst.stream().filter(l -> l.getEmail().equals("philippe.possemiers@ap.be")).forEach(l -> System.out.println(l.getName()));
    }
}
