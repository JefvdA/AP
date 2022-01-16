package Bar;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Bar {
    public static void main(String[] args) {
        AlcoholicDrink wine = new AlcoholicDrink(4.09f, "Wine", 12f);
        AlcoholicDrink beer = new AlcoholicDrink(2.09f, "Beer", 4f);
        NonAlcoholicDrink cola = new NonAlcoholicDrink(1.99f, "Cola", true);
        NonAlcoholicDrink water = new NonAlcoholicDrink(1.49f, "Water", false);

        List<NonAlcoholicDrink> nonAlcoholicDrinkList = new ArrayList<>();
        nonAlcoholicDrinkList.add(cola);
        nonAlcoholicDrinkList.add(water);

        List<AlcoholicDrink> alcoholicDrinkList = new ArrayList<>();
        alcoholicDrinkList.add(wine);
        alcoholicDrinkList.add(beer);

        List<Drink> drinkList = new ArrayList<>();
        drinkList.addAll(nonAlcoholicDrinkList);
        drinkList.addAll(alcoholicDrinkList);

        Collections.sort(drinkList, new SortByPrice());
        System.out.println(drinkList);

        Collections.sort(nonAlcoholicDrinkList, new SortBySpark());
        System.out.println(nonAlcoholicDrinkList);

        Collections.sort(alcoholicDrinkList, new SortByAlcoholPercentage());
        System.out.println(alcoholicDrinkList);
    }
}
