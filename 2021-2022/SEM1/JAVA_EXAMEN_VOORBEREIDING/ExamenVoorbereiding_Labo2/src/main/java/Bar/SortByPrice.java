package Bar;

import java.util.Comparator;

public class SortByPrice implements Comparator<Drink> {
    @Override
    public int compare(Drink o1, Drink o2) {
        return o1.getPrice() < o2.getPrice() ? -1 : 1;
    }
}
