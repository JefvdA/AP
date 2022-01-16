package Garage;

import java.util.ArrayList;

public class Garage {
    public static void main(String[] args) {
        SportCar sportCar = new SportCar(0, CarBrand.BMW, 11000, 13482, "1APT199", 110);
        FamilyCar familyCar = new FamilyCar(1, CarBrand.VOLKSWAGEN, 58000, 38202, "HFD584", 7, true);

        ArrayList<Car> carList = new ArrayList<>();
        carList.add(sportCar);
        carList.add(familyCar);

        System.out.println(carList);
    }
}
