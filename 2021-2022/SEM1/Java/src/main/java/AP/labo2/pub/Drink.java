package AP.labo2.pub;

import java.util.Objects;

public abstract class Drink implements Comparable<Drink> {
    private float price;
    private String name;

    public float getPrice() {
        return price;
    }

    public void setPrice(float price) {
        this.price = price;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Drink() {
    }

    public Drink(float price, String name) {
        this.price = price;
        this.name = name;
    }

    @Override
    public int compareTo(Drink o) {
        if(this.price == o.price)
            return this.name.compareTo(o.getName());
        else if(this.price > o.price)
            return 1;
        else
            return -1;
    }

    @Override
    public String toString() {
        return "Drink{" +
                "price=" + price +
                ", name='" + name + '\'' +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Drink drink = (Drink) o;
        return Float.compare(drink.price, price) == 0 && Objects.equals(name, drink.name);
    }

    @Override
    public int hashCode() {
        return Objects.hash(price, name);
    }
}
