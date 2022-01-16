package Bar;

import java.util.Comparator;

public class SortByAlcoholPercentage implements Comparator<AlcoholicDrink> {
    @Override
    public int compare(AlcoholicDrink o1, AlcoholicDrink o2) {
        return o1.getAlcoholPercentage() < o2.getAlcoholPercentage() ? -1 : 1;
    }
}
