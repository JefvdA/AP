package AP.PizzaShop;

import java.util.List;
import java.util.Objects;

public class Pizza {
    private String name;
    private String price;
    private String type;
    private List<String> ingredients;

    public String getName() {
        return name;
    }

    public String getPrice() {
        return price;
    }

    public String getType() {
        return type;
    }

    public List<String> getIngredients() {
        return ingredients;
    }

    public Pizza(String name, String price, String type, List<String> ingredients) {
        this.name = name;
        this.price = price;
        this.type = type;
        this.ingredients = ingredients;
    }

    @Override
    public String toString() {
        return "Pizza{" +
                "name='" + name + '\'' +
                ", price='" + price + '\'' +
                ", type='" + type + '\'' +
                ", ingredients=" + ingredients +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Pizza pizza = (Pizza) o;
        return Objects.equals(name, pizza.name) && Objects.equals(price, pizza.price) && Objects.equals(type, pizza.type) && Objects.equals(ingredients, pizza.ingredients);
    }

    @Override
    public int hashCode() {
        return Objects.hash(name, price, type, ingredients);
    }
}
