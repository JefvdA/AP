package AP.labo2.pub;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Objects;

public class DrinkList {
    private ArrayList<Drink> drinks = new ArrayList<Drink>();

    public ArrayList<Drink> getDrinks() {
        return drinks;
    }

    public DrinkList() {
    }

    public void AddDrink(Drink drink){
        drinks.add(drink);
    }

    public void Sort(){
    }

    // Compare to in both Non- and AlcoholicDrinks -> choose the right one based on which on the drink is

    @Override
    public String toString() {
        String string = "DrinkList{\n";

        for(Drink drink : drinks){
            String drinkString = drink.toString();
            string += drinkString + "\n";
        }

        string += "}";
        return string;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        DrinkList drinkList = (DrinkList) o;
        return Objects.equals(drinks, drinkList.drinks);
    }

    @Override
    public int hashCode() {
        return Objects.hash(drinks);
    }
}
