package AP.PizzaShop;

import java.util.List;
import java.util.Scanner;

/**
 * This is the Main class for the PizzaShop Application
 * It utilizes the 'PizzaTool' class which offers data about our pizza's
 *
 * @author JefvdA
 * @version 0.0.1
 * @since 15/11/2021
 */
public class Main {
    public static void main(String[] args) {
        PizzaTool pizzaTool = PizzaTool.getInstance();

        greet();

        System.out.println(pizzaTool.getPizzaData());
    }

    /**
     * This method will greet the user
     */
    private static void greet(){
        System.out.println("Welcome to DOMINO'S!");
        System.out.println("Hi " + getName());
    }

    /**
     * This method will ask the user for their name , and return it
     * @return name : String
     */
    private static String getName(){
        System.out.print("What is your name?   >>>");
        Scanner name = new Scanner(System.in);
        return name.nextLine();
    }
}
