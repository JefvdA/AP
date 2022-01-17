package edu.ap.jefvda.examen_vraag1_jefvanderavoirt;

import edu.ap.jefvda.examen_vraag1_jefvanderavoirt.entity.Car;

import java.util.Comparator;

public class SortByPurchasePrice implements Comparator<Car> {
    @Override
    public int compare(Car o1, Car o2) {
        return (int)(o1.getPurchasePrice() - o2.getPurchasePrice());
    }
}
