package edu.ap.jefvda.examen_vraag1_jefvanderavoirt;

import edu.ap.jefvda.examen_vraag1_jefvanderavoirt.dao.CarDao;
import edu.ap.jefvda.examen_vraag1_jefvanderavoirt.entity.Car;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.*;

public class CarController {
    static CarDao carDao;

    public static void main(String[] args) {
        carDao = new CarDao();

        startUIApp();
    }

    private static void startUIApp() {
        System.out.println("Welcome to the best car dealer");

        boolean runApp = true;
        while (runApp){
            int menuOption = getMainMenuOption();
            switch (menuOption){
                case 1:
                    addCar();
                    break;
                case 2:
                    showInventory();
                    break;
                case 3:
                    runApp = false;
                    break;
                default:
                    System.out.println("Sorry, that is a wrong choice... Try again!");
                    break;
            }
        }
    }

    private static void showInventory() {
        List<Car> cars = carDao.getCars();

        // Print all cars
        cars.forEach(System.out::println);

        // Calculate total price of all cars
        final float[] totalPrice = {0};
        cars.forEach(car -> totalPrice[0] += car.getPurchasePrice());
        System.out.println("The total price in this garage is: " + totalPrice[0]);

        // Sort cars if user wants to
        Comparator<Car> comparator = null;

        int sortingOption = getSortingMenuOption();
        switch (sortingOption){
            case 1:
                comparator = new SortByFirstRegisteryDate();
                break;
            case 2:
                comparator = new SortByPurchasePrice();
                break;
            default:
                System.out.println("You didn't want to sort the list.");
                break;
        }

        if(comparator != null){
            Collections.sort(cars, comparator);

            carDao.replaceCars(cars);

            System.out.println("The cars are now sorted, go back to showInventory to see the changes!");
        }

    }

    private static void addCar() {
        System.out.println("U chose 'Add a car'!");

        // Try-catch to check user-input
        try {
            String carBrand = getInputString("Give the brand of the car: ");
            String carModel = getInputString("Give the model of the car: ");
            Date firstRegisteryDate = new SimpleDateFormat("dd/MM/yyyy").parse(getInputString("Give the first registery date of the car (dd/mm/yyyy): "));
            CarType carType = CarType.fromInt(getCarTypeMenuOption()-1);
            float purchasePrice = Float.parseFloat(getInputString("Give the purchase price: "));
            carDao.createCar(carBrand, carModel, firstRegisteryDate, carType, purchasePrice);

        } catch (ParseException e) {
            e.printStackTrace();
        }
    }

    private static int getMainMenuOption() {
        System.out.println("Choose action");
        System.out.println("1. Add a car");
        System.out.println("2. Show inventory");
        System.out.println("3. Stop");

        return getInputInt("Give the number of your choice: ");
    }

    private static int getCarTypeMenuOption() {
        System.out.println("Choose Type");
        System.out.println("1. SUV");
        System.out.println("2. BREAK");
        System.out.println("3. SEDAN");
        System.out.println("4. HATCHBACK");
        System.out.println("5. SPORT");

        return getInputInt("Give the number of your choice: ");
    }

    private static int getSortingMenuOption() {
        System.out.println("Choose sorting method");
        System.out.println("1. By firstRegisteryDate");
        System.out.println("2. By purchasePrice");
        System.out.println("Any other option will mean no sorting");

        return getInputInt("Give the number of your choice: ");
    }

    private static int getInputInt(String question){
        System.out.println(question);
        Scanner consoleInput = new Scanner(System.in);
        return consoleInput.nextInt();
    }

    private static String getInputString(String question){
        System.out.println(question);
        Scanner consoleInput = new Scanner(System.in);
        return consoleInput.nextLine();
    }
}
