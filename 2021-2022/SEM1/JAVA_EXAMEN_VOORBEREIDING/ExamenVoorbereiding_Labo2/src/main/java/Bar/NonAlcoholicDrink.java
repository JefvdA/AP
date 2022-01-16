package Bar;

import java.util.Objects;

public class NonAlcoholicDrink extends Drink {
    private Boolean spark;

    public NonAlcoholicDrink(float price, String name, Boolean spark) {
        super(price, name);
        this.spark = spark;
    }

    public Boolean getSpark() {
        return spark;
    }

    public void setSpark(Boolean spark) {
        this.spark = spark;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        if (!super.equals(o)) return false;
        NonAlcoholicDrink that = (NonAlcoholicDrink) o;
        return Objects.equals(spark, that.spark);
    }

    @Override
    public int hashCode() {
        return Objects.hash(super.hashCode(), spark);
    }

    @Override
    public String toString() {
        return "NonAlcoholicDrink{" +
                "spark=" + spark +
                "} " + super.toString();
    }
}
