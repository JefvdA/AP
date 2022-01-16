package Bar;

import java.util.Comparator;

public class SortBySpark implements Comparator<NonAlcoholicDrink> {
    @Override
    public int compare(NonAlcoholicDrink o1, NonAlcoholicDrink o2) {
        return Boolean.compare(o1.getSpark(), o2.getSpark());
    }
}
