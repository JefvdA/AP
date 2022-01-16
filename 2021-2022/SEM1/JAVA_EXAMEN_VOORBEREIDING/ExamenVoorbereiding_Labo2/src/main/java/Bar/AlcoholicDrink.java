package Bar;

import java.util.Objects;

public class AlcoholicDrink extends Drink {
    private float alcoholPercentage;

    public AlcoholicDrink(float price, String name, float alcoholPercentage) {
        super(price, name);
        this.alcoholPercentage = alcoholPercentage;
    }

    public float getAlcoholPercentage() {
        return alcoholPercentage;
    }

    public void setAlcoholPercentage(float alcoholPercentage) {
        this.alcoholPercentage = alcoholPercentage;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        if (!super.equals(o)) return false;
        AlcoholicDrink that = (AlcoholicDrink) o;
        return Float.compare(that.alcoholPercentage, alcoholPercentage) == 0;
    }

    @Override
    public int hashCode() {
        return Objects.hash(super.hashCode(), alcoholPercentage);
    }

    @Override
    public String toString() {
        return "AlcoholicDrink{" +
                "alcoholPercentage=" + alcoholPercentage +
                "} " + super.toString();
    }
}
