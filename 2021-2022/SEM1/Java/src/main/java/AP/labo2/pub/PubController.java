package AP.labo2.pub;

import java.util.Collections;

public class PubController {
    public static void main(String[] args) {
        DrinkList drinkList = new DrinkList();

        DrinkAlcoholic alcoholicDrink = new DrinkAlcoholic(2.5f, "Beer", 0.06f);
        DrinkNonAlcoholic nonAlcoholicDrink = new DrinkNonAlcoholic(2f, "Coca-cola", true);
        DrinkNonAlcoholic nonAlcoholicDrink2 = new DrinkNonAlcoholic(2f, "Water", false);

        drinkList.AddDrink(alcoholicDrink);
        drinkList.AddDrink(nonAlcoholicDrink2);
        drinkList.AddDrink(nonAlcoholicDrink);

        drinkList.Sort();
        System.out.print(drinkList);
    }
}
