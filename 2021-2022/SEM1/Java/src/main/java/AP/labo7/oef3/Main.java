package AP.labo7.oef3;

import AP.labo7.Person;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        List<Person> lectorenLijst = new ArrayList<>();
        lectorenLijst.add(new Person("Kelly", "Casal", "kelly.casalmosteiro@ap.be"));
        lectorenLijst.add(new Person("Olga", "Coutrin", "olga.coutrin@ap.be"));
        lectorenLijst.add(new Person("Philippe", "Possemiers", "philippe.possemiers@ap.be"));
        System.out.println("\n=== E-Mail ===");

        lectorenLijst.forEach(l -> {
            System.out.println(l.getEmail());
        });
    }
}
