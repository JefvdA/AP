package AP.labo7.oef6;

import AP.labo7.Person;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        Person lector = findPersonbyName();
        System.out.println(lector);
    }

    private static Person findPersonbyName(){
        List<Person> lectorenLijst = new ArrayList<>();
        lectorenLijst.add(new Person("Kelly", "Casal", "kelly.casalmosteiro@ap.be"));
        lectorenLijst.add(new Person("Olga", "Coutrin", "olga.coutrin@ap.be"));
        lectorenLijst.add(new Person("Philippe", "Possemiers", "philippe.possemiers@ap.be"));

        return lectorenLijst.stream()
                .filter(l -> l.getEmail().equals("philippe.possemiers@ap.be") && l.getName().equals("Philippe Possemiers") )
                .findAny()
                .orElse(null);
    }
}
