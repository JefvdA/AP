package Garage;

import java.util.Comparator;

public class SortByKmDriven implements Comparator<Car> {
    @Override
    public int compare(Car o1, Car o2) {
        if(o1.getKmDriven() != o2.getKmDriven())
            return o1.getKmDriven() < o2.getKmDriven() ? -1 : 1;

        return 0;
    }
}
