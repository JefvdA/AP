package AP.labo7.oef5;

import AP.labo7.Person;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        List<Person> lectorenLijst = new ArrayList<>();
        lectorenLijst.add(new Person("Kelly", "Casal", "kelly.casalmosteiro@ap.be"));
        lectorenLijst.add(new Person("Olga", "Coutrin", "olga.coutrin@ap.be"));
        lectorenLijst.add(new Person("Philippe", "Possemiers", "philippe.possemiers@ap.be"));
        System.out.println("\n=== print Name with stream ===");

        List<Person> filtered = lectorenLijst.stream().filter(l -> l.getEmail().equals("philippe.possemiers@ap.be")).collect(Collectors.toList());
        filtered.forEach(l -> System.out.println(l.getName()));
    }
}
