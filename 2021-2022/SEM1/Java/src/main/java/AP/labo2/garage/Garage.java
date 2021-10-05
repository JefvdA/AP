package AP.labo2.garage;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Objects;

public class Garage {
    ArrayList<Car> cars = new ArrayList<Car>();

    public ArrayList<Car> getCars() {
        return cars;
    }

    public void AddCar(Car car){
        cars.add(car);
    }

    public void Sort(){
        Collections.sort(cars);
    }

    public void Sort(Comparator<Car> comparator){
        Collections.sort(cars, comparator);
    }

    @Override
    public String toString() {
        String string = "Garage {\n";

        for(Car car : cars)
            string += car.toString() + "\n";

        string += "} \n";
        return string;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Garage garage = (Garage) o;
        return Objects.equals(cars, garage.cars);
    }

    @Override
    public int hashCode() {
        return Objects.hash(cars);
    }
}
