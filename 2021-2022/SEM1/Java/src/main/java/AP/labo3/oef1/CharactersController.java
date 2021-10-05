package AP.labo3.oef1;

import java.util.ArrayList;
import java.util.Random;

public class CharactersController {
    public static void main(String[] args) {

        ArrayList<Person> characters = new ArrayList<Person>();

        characters.add(new Person("Rick", "Grimes"));
        characters.add(new Person("Carl", "Grimes"));
        characters.add(new Person("Andrea", "Unkown"));
        characters.add(new Person("Michelle", "Unknown"));
        characters.add(new Person("Lori", "Unknown"));

        System.out.print("ORIGINAL:");
        System.out.print(characters + "\n");

        removeItems(characters, 2);
        System.out.print("DELETED:");
        System.out.print(characters);
    }

    static void removeItems(ArrayList list,Integer amount){
        Random random = new Random();

        if(amount > list.size()) amount = list.size();
        for (int i = 0; i < amount; i++) {
            int randInt = random.nextInt(amount);
            list.remove(i);
        }
    }
}
