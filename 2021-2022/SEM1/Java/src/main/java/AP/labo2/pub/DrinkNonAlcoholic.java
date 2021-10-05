package AP.labo2.pub;

import java.util.Objects;

public class DrinkNonAlcoholic extends Drink {
    private Boolean hasGas;

    public Boolean getHasGas() {
        return hasGas;
    }

    public void setHasGas(Boolean hasGas) {
        this.hasGas = hasGas;
    }

    public DrinkNonAlcoholic() {
        super();
    }

    public DrinkNonAlcoholic(float price, String name, Boolean hasGas) {
        super(price, name);
        this.hasGas = hasGas;
    }

    @Override
    public int compareTo(Drink o) {
        DrinkNonAlcoholic drinkNonAlcoholic = (DrinkNonAlcoholic) o;

        return this.hasGas.compareTo(drinkNonAlcoholic.getHasGas());
    }

    @Override
    public String toString() {
        return "DrinkNonAlcoholic{" +
                "hasGas=" + hasGas +
                "} " + super.toString();
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        if (!super.equals(o)) return false;
        DrinkNonAlcoholic that = (DrinkNonAlcoholic) o;
        return Objects.equals(hasGas, that.hasGas);
    }

    @Override
    public int hashCode() {
        return Objects.hash(super.hashCode(), hasGas);
    }
}
