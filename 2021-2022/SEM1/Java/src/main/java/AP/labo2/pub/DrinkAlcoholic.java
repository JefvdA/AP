package AP.labo2.pub;

import java.util.Objects;

public class DrinkAlcoholic extends Drink {
    private float alcoholPercentage;

    public float getAlcoholPercentage() {
        return alcoholPercentage;
    }

    public void setAlcoholPercentage(float alcoholPercentage) {
        this.alcoholPercentage = alcoholPercentage;
    }

    public DrinkAlcoholic() {
    }

    public DrinkAlcoholic(float price, String name, float alcoholPercentage) {
        super(price, name);
        this.alcoholPercentage = alcoholPercentage;
    }

    @Override
    public int compareTo(Drink o) {
        DrinkAlcoholic drink = (DrinkAlcoholic) o;

        if(this.alcoholPercentage == drink.getAlcoholPercentage())
            return super.compareTo(drink);
        else if(this.alcoholPercentage > drink.getAlcoholPercentage())
            return 1;
        else
            return -1;
    }

    @Override
    public String toString() {
        return "DrinkAlcoholic{" +
                "alcoholPercentage=" + alcoholPercentage +
                "} " + super.toString();
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        if (!super.equals(o)) return false;
        DrinkAlcoholic that = (DrinkAlcoholic) o;
        return Float.compare(that.alcoholPercentage, alcoholPercentage) == 0;
    }

    @Override
    public int hashCode() {
        return Objects.hash(super.hashCode(), alcoholPercentage);
    }
}
