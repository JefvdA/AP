package edu.ap.jefvda.examen_vraag1_jefvanderavoirt;

import edu.ap.jefvda.examen_vraag1_jefvanderavoirt.entity.Car;

import java.util.Comparator;

public class SortByFirstRegisteryDate implements Comparator<Car> {
    @Override
    public int compare(Car o1, Car o2) {
        return o1.getFirstRegisteryDate().compareTo(o2.getFirstRegisteryDate());
    }
}
